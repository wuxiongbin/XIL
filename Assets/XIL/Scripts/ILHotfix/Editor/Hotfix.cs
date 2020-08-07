#if USE_HOT
using System.Collections.Generic;
using System;
using System.Reflection;
using System.Linq;
using System.IO;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace wxb.Editor
{
    public static class Hotfix
    {
        static TypeReference objType = null;

        static TypeDefinition delegateBridgeType = null;
        static MethodDefinition delegateBridgeGetter = null;
        static MethodReference hotfixFlagGetter = null;

        static MethodDefinition invokeSessionStart = null;
        static MethodDefinition functionInvoke = null;
        static MethodDefinition invokeSessionEnd = null;
        static MethodDefinition invokeSessionEndWithResult = null;
        static MethodDefinition inParam = null;
        static MethodDefinition inParams = null;
        static MethodDefinition outParam = null;

        internal static Dictionary<string, int> hotfixCfg;

        static List<MethodDefinition> bridgeIndexByKey;

        static void init(AssemblyDefinition assembly)
        {
            objType = assembly.MainModule.ImportReference(typeof(object));
            delegateBridgeType = assembly.MainModule.Types.Single(t => t.FullName == "IL.DelegateBridge");
            invokeSessionStart = delegateBridgeType.Methods.Single(m => m.Name == "InvokeSessionStart");
            functionInvoke = delegateBridgeType.Methods.Single(m => m.Name == "Invoke");
            invokeSessionEnd = delegateBridgeType.Methods.Single(m => m.Name == "InvokeSessionEnd");
            invokeSessionEndWithResult = delegateBridgeType.Methods.Single(m => m.Name == "InvokeSessionEndWithResult");
            inParam = delegateBridgeType.Methods.Single(m => m.Name == "InParam");
            inParams = delegateBridgeType.Methods.Single(m => m.Name == "InParams");
            outParam = delegateBridgeType.Methods.Single(m => m.Name == "OutParam");

            bridgeIndexByKey = new List<MethodDefinition>();

            var resolver = assembly.MainModule.AssemblyResolver as BaseAssemblyResolver;
            foreach (var path in (from asm in AppDomain.CurrentDomain.GetAssemblies() select asm.ManifestModule.FullyQualifiedName).Distinct())
            {
                try
                {
                    resolver.AddSearchDirectory(System.IO.Path.GetDirectoryName(path));
                }
                catch(Exception)
                {

                }
            }

            shortToLong.Clear();
            var nameToOpcodes = typeof(OpCodes).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
    .ToDictionary(f => f.Name, f => ((OpCode)f.GetValue(null)));
            foreach (var kv in nameToOpcodes)
            {
                if (kv.Key.EndsWith("_S"))
                {
                    shortToLong[kv.Value] = nameToOpcodes[kv.Key.Substring(0, kv.Key.Length - 2)];
                }
            }
        }

        static List<MethodDefinition> hotfix_bridges = null;

        static bool isSameType(TypeReference left, TypeReference right)
        {
            return left.FullName == right.FullName
                && left.Module.Assembly.FullName == right.Module.Assembly.FullName
                && left.Module.FullyQualifiedName == right.Module.FullyQualifiedName;
        }

        static bool hasGenericParameter(TypeReference type)
        {
            if (type.HasGenericParameters)
            {
                return true;
            }
            if (type.IsByReference)
            {
                return hasGenericParameter(((ByReferenceType)type).ElementType);
            }
            if (type.IsArray)
            {
                return hasGenericParameter(((ArrayType)type).ElementType);
            }
            if (type.IsGenericInstance)
            {
                foreach (var typeArg in ((GenericInstanceType)type).GenericArguments)
                {
                    if (hasGenericParameter(typeArg))
                    {
                        return true;
                    }
                }
                return false;
            }
            return type.IsGenericParameter;
        }

        static bool isNoPublic(AssemblyDefinition assembly, TypeReference type)
        {
            if (type.IsByReference)
            {
                return isNoPublic(assembly, ((ByReferenceType)type).ElementType);
            }
            if (type.IsArray)
            {
                return isNoPublic(assembly, ((ArrayType)type).ElementType);
            }
            else
            {
                if (type.IsGenericInstance)
                {
                    foreach (var typeArg in ((GenericInstanceType)type).GenericArguments)
                    {
                        if (isNoPublic(assembly, typeArg))
                        {
                            return true;
                        }
                    }
                }

                var resolveType = type.Resolve();
                if ((!type.IsNested && !resolveType.IsPublic) || (type.IsNested && !resolveType.IsNestedPublic))
                {
                    return true;
                }
                if (type.IsNested)
                {
                    var parent = type.DeclaringType;
                    while (parent != null)
                    {
                        var resolveParent = parent.Resolve();
                        if ((!parent.IsNested && !resolveParent.IsPublic) || (parent.IsNested && !resolveParent.IsNestedPublic))
                        {
                            return true;
                        }
                        if (parent.IsNested)
                        {
                            parent = parent.DeclaringType;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                return false;
            }
        }

        static bool genericInOut(AssemblyDefinition assembly, MethodDefinition method)
        {
            if (hasGenericParameter(method.ReturnType) || isNoPublic(assembly, method.ReturnType))
            {
                return true;
            }
            var parameters = method.Parameters;

            if (!method.IsStatic && method.IsConstructor && (hasGenericParameter(method.DeclaringType) || (method.DeclaringType.IsValueType && isNoPublic(assembly, method.DeclaringType))))
            {
                return true;
            }

            if (method.DeclaringType.IsGenericParameter || method.DeclaringType.HasGenericParameters)
                return true;

            for (int i = 0; i < parameters.Count; i++)
            {
                if (hasGenericParameter(parameters[i].ParameterType) || ((parameters[i].ParameterType.IsValueType || parameters[i].ParameterType.IsByReference) && isNoPublic(assembly, parameters[i].ParameterType)))
                {
                    return true;
                }
            }
            return false;
        }

        [UnityEditor.Callbacks.PostProcessScene]
        [UnityEditor.MenuItem("XIL/Hotfix Inject In Editor", false, 3)]
        public static void Inject()
        {
            if (UnityEngine.Application.isPlaying)
                return;

            if (UnityEditor.EditorApplication.isCompiling)
            {
                UnityEngine.Debug.LogError("正在编译中，请编译完之后再点击!");
                return;
            }

            try
            {
                System.Func<HashSet<string>> func = () => { return new HashSet<string>(GenAutoExport.FixMarkIL()); };
                HotfixInject("./Library/ScriptAssemblies/Assembly-CSharp.dll", func);
                string file = "./Library/PlayerScriptAssemblies/Assembly-CSharp.dll";
                if (System.IO.File.Exists(file))
                {
                    //Log.Debug("PlayerScriptAssemblies begin");
                    HotfixInject(file, func);
                    //Log.Debug("PlayerScriptAssemblies end");
                }
            }
            catch (System.Exception ex)
            {
                wxb.L.LogException(ex);
            }
        }

        static bool IsContainEditor(CustomAttribute att)
        {
            switch (att.AttributeType.FullName)
            {
            case "EditorClass":
            case "EditorField":
                return true;
            }

            return false;
        }

        static bool injectType(AssemblyDefinition assembly, TypeReference hotfixAttributeType, TypeDefinition type, HashSet<string> exports)
        {
            foreach(var nestedTypes in type.NestedTypes)
            {
                if (!injectType(assembly, hotfixAttributeType, nestedTypes, exports))
                {
                    return false;
                }
            }
            if (type.Name.Contains("<") || type.IsInterface || type.Methods.Count == 0) // skip anonymous type and interface
            {
                return true;
            }

            CustomAttribute hotfixAttr = type.CustomAttributes.FirstOrDefault(ca => ca.AttributeType == hotfixAttributeType);
            if (hotfixAttr == null && !exports.Contains(type.FullName))
                return true;

            bool isUnityObject = IsUnityObjectType(type);
            List<MethodDefinition> methods = new List<MethodDefinition>(type.Methods);
            foreach (var method in methods)
            {
                if (method.ReturnType.IsByReference)
                {
                    L.LogErrorFormat("{0} 返回值为ref类型，不能Hotfix此接口!", method.FullName);
                    continue; // 返回值为引用类型的，不能hotfix
                }

                bool isEditorCall = false;
                if (method.IsSpecialName && (method.Name.StartsWith("get_") || method.Name.StartsWith("set_")))
                {
                    string propertyName = method.Name.Substring(4);
                    foreach (var ator in type.Properties)
                    {
                        if (ator.Name == propertyName)
                        {
                            foreach (var att in ator.CustomAttributes)
                            {
                                if (IsContainEditor(att))
                                {
                                    isEditorCall = true;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
                else
                {
                    foreach (var att in method.CustomAttributes)
                    {
                        if (IsContainEditor(att))
                        {
                            isEditorCall = true;
                            break;
                        }
                    }
                }

                if (isEditorCall)
                    continue;

                if (method.Name != ".cctor" && !method.IsAbstract && !method.IsPInvokeImpl && method.Body != null && !method.Name.Contains("<"))
                {
                    if (isUnityObject && method.IsConstructor)
                        continue;

                    if ((method.HasGenericParameters || genericInOut(assembly, method)))
                    {
                        if (!injectGenericMethod(assembly, method))
                        {
                            //Error(string.Format("type:{0} method:{1} error!", method.DeclaringType.Name, method.Name));
                            return false;
                        }
                    }
                    else
                    {
                        if (!injectMethod(assembly, method))
                        {
                            //Error(string.Format("type:{0} method:{1} error!", method.DeclaringType.Name, method.Name));
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        static bool IsUnityObjectType(TypeReference type)
        {
            if (type.FullName == "UnityEngine.Object")
                return true;

            if (type.Resolve().BaseType == null)
                return false;

            return IsUnityObjectType(type.Resolve().BaseType);
        }

        public static void HotfixInject(string inject_assembly_path, Func<HashSet<string>> fun)
        {
            AssemblyDefinition assembly = null;
            try
            {
                var readerParameters = new ReaderParameters
                {
                    ReadSymbols = true,
                    InMemory = true,
                };

                string pdb = System.IO.Path.ChangeExtension(inject_assembly_path, ".pdb");
                if (System.IO.File.Exists(pdb))
                {
                    readerParameters.SymbolReaderProvider = new PortablePdbReaderProvider();
                }
                else
                {
                    readerParameters.SymbolReaderProvider = new Mono.Cecil.Mdb.MdbReaderProvider();
                }
                assembly = AssemblyDefinition.ReadAssembly(inject_assembly_path, readerParameters);

                init(assembly);

                if (assembly.MainModule.Types.Any(t => t.Name == "__IL_GEN_FLAG"))
                {
                    Info("had injected!");
                    return;
                }

                var exports = fun();
                assembly.MainModule.Types.Add(new TypeDefinition("__IL_GEN", "__IL_GEN_FLAG", Mono.Cecil.TypeAttributes.Class, objType));

                hotfix_bridges = (from method in delegateBridgeType.Methods where method.Name.StartsWith("__Gen_Delegate_Imp") select method).ToList();

                var hotfixAttributeType = assembly.MainModule.Types.Single(t => t.FullName == "wxb.HotfixAttribute");
                foreach (var type in (from module in assembly.Modules from type in module.Types select type))
                {
                    if (!injectType(assembly, hotfixAttributeType, type, exports))
                    {
                        return;
                    }
                }

                var writerParameters = new WriterParameters { WriteSymbols = true };
                assembly.Write(inject_assembly_path, writerParameters);
                Info("hotfix inject finish!");
            }
            catch(Exception e)
            {
                Error("Exception! " + e);
            }
            finally
            {
                if (assembly != null)
                {
                    Clean(assembly);
                }
            }
        }

        static void Info(string info)
        {
            wxb.L.Log(info);
        }

        static void Error(string info)
        {
            wxb.L.LogError("Error:" + info);
        }

        static void Clean(AssemblyDefinition assembly)
		{
			if (assembly.MainModule.SymbolReader != null)
			{
				assembly.MainModule.SymbolReader.Dispose();
			}

            assembly.Dispose();
        }

        static OpCode[] ldargs = new OpCode[] { OpCodes.Ldarg_0, OpCodes.Ldarg_1, OpCodes.Ldarg_2, OpCodes.Ldarg_3 };

        static readonly int MAX_OVERLOAD = 100;

        class StrMethod
        {
            public StrMethod(string name)
            {
                this.name = name;
                methods = new List<MethodDefinition>();
            }

            public string name;
            public List<MethodDefinition> methods;

            static string GetKey(MethodDefinition method)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append(method.ReturnType.FullName);
                sb.Append("(");
                for (int i = 0; i < method.Parameters.Count; ++i)
                {
                    if (i != 0)
                        sb.Append(",");
                    sb.Append(method.Parameters[i].ParameterType.FullName);
                }
                sb.Append(")");

                return sb.ToString();
            }

            public void Sorted()
            {
                methods.Sort((x, y) => 
                {
                    if (x == y)
                        return 0;

                    var xc = x.Parameters;
                    var yc = y.Parameters;
                    if (xc.Count != yc.Count)
                        return xc.Count.CompareTo(yc.Count);

                    // 参数一样，那么以类型来排序
                    string kx = GetKey(x);
                    string ky = GetKey(y);
                    if (kx == ky)
                        wxb.L.LogError("key same! + " + x.Name);

                    return kx.CompareTo(ky);
                });
            }

            public int Count { get { return methods.Count; } }

            // 所有函数的参数都是不一样
            //public bool isNotSameParam
            //{
            //    get
            //    {
            //        bool value = true; // 先假设所有参数个数都不一样
            //        HashSet<int> hss = new HashSet<int>();
            //        foreach (var ator in methods)
            //        {
            //            if (!hss.Add(ator.Parameters.Count))
            //            {
            //                value = false;
            //                break;
            //            }
            //        }

            //        return value;
            //    }
            //}
        }

        static string getDelegateName(MethodDefinition method)
        {
            string fieldName = method.Name;
            if (fieldName.StartsWith("."))
            {
                fieldName = fieldName.Substring(1);
            }
            string ccFlag = method.IsConstructor ? "_c" : "";
            var type = method.DeclaringType;
            Dictionary<string, StrMethod> nameToCount = new Dictionary<string, StrMethod>();
            StrMethod strMethod = null;
            {
                foreach (var ator in type.Methods)
                {
                    if (!nameToCount.TryGetValue(ator.Name, out strMethod))
                    {
                        strMethod = new StrMethod(ator.Name);
                        nameToCount.Add(ator.Name, strMethod);
                    }

                    strMethod.methods.Add(ator);
                }

                strMethod = nameToCount[method.Name];
            }

            string name = ccFlag + "__Hotfix_" + fieldName;
            if (strMethod.Count == 1)
                return name;

            // 是否所有函数的参数个数都不一样
            //if (strMethod.isNotSameParam)
            //    return name + "_" + method.Parameters.Count;

            strMethod.Sorted();
            for (int i = 0; i <strMethod.methods.Count; ++i)
            {
                if (strMethod.methods[i] == method)
                    return name + "_" + i;
            }

            wxb.L.LogErrorFormat("method:{0} not field name!", method.Name);
            return "";
        }

        static Instruction findNextRet(Mono.Collections.Generic.Collection<Instruction> instructions, Instruction pos)
        {
            bool posFound = false;
            for(int i = 0; i < instructions.Count; i++)
            {
                if (posFound && instructions[i].OpCode == OpCodes.Ret)
                {
                    return instructions[i];
                }
                else if (instructions[i] == pos)
                {
                    posFound = true;
                }
            }
            return null;
        }

        static bool findHotfixDelegate(AssemblyDefinition assembly, MethodDefinition method, out MethodReference invoke)
        {
            for (int i = 0; i < hotfix_bridges.Count; i++)
            {
                MethodDefinition hotfix_bridge = hotfix_bridges[i];
                var returnType = method.ReturnType;
                if (isSameType(returnType, hotfix_bridge.ReturnType))
                {
                    var parametersOfDelegate = hotfix_bridge.Parameters;
                    int compareOffset = 0;
                    if (!method.IsStatic)
                    {
                        var typeOfSelf = objType;
                        if ((parametersOfDelegate.Count == 0) || parametersOfDelegate[0].ParameterType.IsByReference || !isSameType(typeOfSelf, parametersOfDelegate[0].ParameterType))
                        {
                            continue;
                        }
                        compareOffset++;
                    }
                    if (method.Parameters.Count != (parametersOfDelegate.Count - compareOffset))
                    {
                        continue;
                    }
                    bool paramMatch = true;
                    for (int j = 0; j < method.Parameters.Count; j++)
                    {
                        var param_left = method.Parameters[j];
                        var param_right = parametersOfDelegate[compareOffset++];
                        if (param_left.IsOut != param_right.IsOut
                            || param_left.ParameterType.IsByReference != param_right.ParameterType.IsByReference)
                        {
                            paramMatch = false;
                            break;
                        }
                        if (param_left.ParameterType.IsValueType != param_right.ParameterType.IsValueType)
                        {
                            paramMatch = false;
                            break;
                        }
                        bool isparam = param_left.CustomAttributes.FirstOrDefault(ca => ca.AttributeType.Name == "ParamArrayAttribute") != null;
                        var type_left = isparam || param_left.ParameterType.IsByReference || param_left.ParameterType.IsValueType || param_left.ParameterType.IsArray ? param_left.ParameterType : objType;
                        if (!isSameType(type_left, param_right.ParameterType))
                        {
                            paramMatch = false;
                            break;
                        }
                    }

                    if (!paramMatch)
                    {
                        continue;
                    }
                    invoke = hotfix_bridge;
                    return true;
                }
            }
            invoke = null;
            return false;
        }

        public static void LogInfo(string key, Mono.Collections.Generic.Collection<Instruction> Instructions)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendFormatLine("{0} Total:{1}", key, Instructions.Count);
            for (int i = 0; i < Instructions.Count; ++i)
            {
                sb.AppendFormatLine("{0}){1}", i, Instructions[i].ToString());
            }
            UnityEngine.Debug.Log(sb.ToString());
        }

        static bool injectMethod(AssemblyDefinition assembly, MethodDefinition method)
        {
            var type = method.DeclaringType;
            
            bool isFinalize = (method.Name == "Finalize" && method.IsSpecialName);

            MethodReference invoke = null;

            int param_count = method.Parameters.Count + (method.IsStatic ? 0 : 1);

            if (!findHotfixDelegate(assembly, method, out invoke))
            {
                Error("查找委托代理失败，请确定是否点击过\"XIL /一键生成\"! can not find delegate for " + method.DeclaringType + "." + method.ToString() + "! try re-genertate code.");
                return false;
            }

            if (invoke == null)
            {
                throw new Exception("unknow exception!");
            }

            invoke = assembly.MainModule.ImportReference(invoke);

            FieldReference fieldReference = null;
            VariableDefinition injection = null;

            injection = new VariableDefinition(invoke.DeclaringType);
            method.Body.Variables.Add(injection);

            var luaDelegateName = getDelegateName(method);
            if (luaDelegateName == null)
            {
                Error("too many overload!");
                return false;
            }

            FieldDefinition fieldDefinition = new FieldDefinition(luaDelegateName, Mono.Cecil.FieldAttributes.Static | Mono.Cecil.FieldAttributes.Private,
                invoke.DeclaringType);
            type.Fields.Add(fieldDefinition);
            fieldReference = fieldDefinition.GetGeneric();

            var insertPoint = method.Body.Instructions[0];
            var processor = method.Body.GetILProcessor();

            if (method.IsConstructor)
            {
                insertPoint = findNextRet(method.Body.Instructions, insertPoint);
            }

            Dictionary<Instruction, Instruction> originToNewTarget = new Dictionary<Instruction, Instruction>();
            HashSet<Instruction> noCheck = new HashSet<Instruction>();

            while (insertPoint != null)
            {
                Instruction firstInstruction;
                firstInstruction = processor.Create(OpCodes.Ldsfld, fieldReference);
                processor.InsertBefore(insertPoint, firstInstruction);
                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Stloc, injection));
                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldloc, injection));

                var jmpInstruction = processor.Create(OpCodes.Brfalse, insertPoint);
                processor.InsertBefore(insertPoint, jmpInstruction);

                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldloc, injection));

                for (int i = 0; i < param_count; i++)
                {
                    if (i < ldargs.Length)
                    {
                        processor.InsertBefore(insertPoint, processor.Create(ldargs[i]));
                    }
                    else if (i < 256)
                    {
                        processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldarg_S, (byte)i));
                    }
                    else
                    {
                        processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldarg, (short)i));
                    }
                    if (i == 0 && !method.IsStatic && type.IsValueType)
                    {
                        processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldobj, type));

                    }
                }

                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Call, invoke));

                if (!method.IsConstructor && !isFinalize)
                {
                    processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ret));
                }

                if (!method.IsConstructor)
                {
                    break;
                }
                else
                {
                    originToNewTarget[insertPoint] = firstInstruction;
                    noCheck.Add(jmpInstruction);
                }
                insertPoint = findNextRet(method.Body.Instructions, insertPoint);
            }

            if (method.IsConstructor)
            {
                fixBranch(processor, method.Body.Instructions, originToNewTarget, noCheck);
            }

            if (isFinalize)
            {
                if (method.Body.ExceptionHandlers.Count == 0)
                {
                    throw new InvalidProgramException("Finalize has not try-catch? Type :" + method.DeclaringType);
                }
                method.Body.ExceptionHandlers[0].TryStart = method.Body.Instructions[0];
            }

            return true;
        }

        static Dictionary<OpCode, OpCode> shortToLong = new Dictionary<OpCode, OpCode>();

        static void fixBranch(ILProcessor processor, Mono.Collections.Generic.Collection<Instruction> instructions, Dictionary<Instruction, Instruction> originToNewTarget, HashSet<Instruction> noCheck)
        {
            foreach (var instruction in instructions)
            {
                Instruction target = instruction.Operand as Instruction;
                if (target != null && !noCheck.Contains(instruction))
                {
                    if (originToNewTarget.ContainsKey(target))
                    {
                        instruction.Operand = originToNewTarget[target];
                    }
                }
            }
            int offset = 0;
            for (int i = 0; i < instructions.Count; i++)
            {
                var instruction = instructions[i];
                instruction.Offset = offset;
                offset += instruction.GetSize();
            }

            for (int i = 0; i < instructions.Count; i++)
            {
                var instruction = instructions[i];
                Instruction target = instruction.Operand as Instruction;

                if (target != null)
                {
                    int diff = target.Offset - instruction.Offset;
                    if ((diff > sbyte.MaxValue || diff < sbyte.MinValue) && shortToLong.ContainsKey(instruction.OpCode))
                    {
                        instructions[i] = processor.Create(shortToLong[instruction.OpCode], target);
                    }
                }
            }
        }

        static MethodReference MakeGenericMethod(this MethodReference self, params TypeReference[] arguments)
        {
            if (self.GenericParameters.Count != arguments.Length)
                throw new ArgumentException();

            var instance = new GenericInstanceMethod(self);
            foreach (var argument in arguments)
                instance.GenericArguments.Add(argument);

            return instance;
        }

        static FieldReference GetGeneric(this FieldDefinition definition)
        {
            if (definition.DeclaringType.HasGenericParameters)
            {
                var declaringType = new GenericInstanceType(definition.DeclaringType);
                foreach (var parameter in definition.DeclaringType.GenericParameters)
                {
                    declaringType.GenericArguments.Add(parameter);
                }
                return new FieldReference(definition.Name, definition.FieldType, declaringType);
            }

            return definition;
        }

        public static TypeReference GetGeneric(this TypeDefinition definition)
        {
            if (definition.HasGenericParameters)
            {
                var genericInstanceType = new GenericInstanceType(definition);
                foreach (var parameter in definition.GenericParameters)
                {
                    genericInstanceType.GenericArguments.Add(parameter);
                }
                return genericInstanceType;
            }

            return definition;
        }

        static bool injectGenericMethod(AssemblyDefinition assembly, MethodDefinition method)
        {
            var type = method.DeclaringType;
            
            bool isFinalize = (method.Name == "Finalize" && method.IsSpecialName);

            FieldReference fieldReference = null;
            VariableDefinition injection = null;
            var luaDelegateName = getDelegateName(method);
            if (luaDelegateName == null)
            {
                Error("too many overload!");
                return false;
            }

            FieldDefinition fieldDefinition = new FieldDefinition(luaDelegateName, Mono.Cecil.FieldAttributes.Static | Mono.Cecil.FieldAttributes.Private, delegateBridgeType);
            type.Fields.Add(fieldDefinition);

            fieldReference = fieldDefinition.GetGeneric();

            injection = new VariableDefinition(delegateBridgeType);
            method.Body.Variables.Add(injection);

            int param_start = method.IsStatic ? 0 : 1;
            int param_count = method.Parameters.Count + param_start;
            var insertPoint = method.Body.Instructions[0];
            var processor = method.Body.GetILProcessor();

            if (method.IsConstructor)
            {
                insertPoint = findNextRet(method.Body.Instructions, insertPoint);
            }

            while (insertPoint != null)
            {
                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldsfld, fieldReference));
                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Stloc, injection));
                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldloc, injection));
                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Brfalse, insertPoint));

                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldloc, injection));

                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Callvirt, invokeSessionStart));

                TypeReference returnType = method.ReturnType;

                bool isVoid = returnType.FullName == "System.Void";

                int outCout = 0;

                for (int i = 0; i < param_count; i++)
                {
                    if (i == 0 && !method.IsStatic)
                    {
                        processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldloc, injection));
                        processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldarg_0));

                        if (type.IsValueType)
                        {
                            processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldobj, method.DeclaringType.GetGeneric()));
                        }
                        processor.InsertBefore(insertPoint, processor.Create(OpCodes.Callvirt, MakeGenericMethod(inParam, method.DeclaringType.GetGeneric())));
                    }
                    else
                    {
                        var param = method.Parameters[i - param_start];
                        if (param.ParameterType.IsByReference)
                        {
                            outCout++;
                        }
                        if (!param.IsOut)
                        {
                            processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldloc, injection));

                            if (i < ldargs.Length)
                            {
                                processor.InsertBefore(insertPoint, processor.Create(ldargs[i]));
                            }
                            else if (i < 256)
                            {
                                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldarg_S, (byte)i));
                            }
                            else
                            {
                                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldarg, (short)i));
                            }

                            var paramType = param.ParameterType;

                            if (param.ParameterType.IsByReference)
                            {
                                paramType = ((ByReferenceType)paramType).ElementType;
                                if (paramType.IsValueType || paramType.IsGenericParameter)
                                {
                                    processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldobj, paramType));
                                }
                                else
                                {
                                    processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldind_Ref));
                                }
                            }
                            if (i == param_count - 1 && param.CustomAttributes.Any(ca => ca.AttributeType.FullName == "System.ParamArrayAttribute"))
                            {
                                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Callvirt, MakeGenericMethod(inParams, ((ArrayType)paramType).ElementType)));
                            }
                            else
                            {
                                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Callvirt, MakeGenericMethod(inParam, paramType)));
                            }
                        }
                    }
                }

                int outStart = (isVoid ? 0 : 1);

                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldloc, injection));
                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldc_I4, outCout + outStart));
                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Callvirt, functionInvoke));

                int outPos = outStart;
                for (int i = 0; i < method.Parameters.Count; i++)
                {
                    if (method.Parameters[i].ParameterType.IsByReference)
                    {
                        processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldloc, injection));
                        processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldc_I4, outPos));
                        int arg_pos = param_start + i;
                        if (arg_pos < ldargs.Length)
                        {
                            processor.InsertBefore(insertPoint, processor.Create(ldargs[arg_pos]));
                        }
                        else if (arg_pos < 256)
                        {
                            processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldarg_S, (byte)arg_pos));
                        }
                        else
                        {
                            processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldarg, (short)arg_pos));
                        }
                        processor.InsertBefore(insertPoint, processor.Create(OpCodes.Callvirt, MakeGenericMethod(outParam,
                            ((ByReferenceType)method.Parameters[i].ParameterType).ElementType)));
                        outPos++;
                    }
                }


                processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldloc, injection));
                if (isVoid)
                {
                    processor.InsertBefore(insertPoint, processor.Create(OpCodes.Callvirt, invokeSessionEnd));
                }
                else
                {
                    processor.InsertBefore(insertPoint, processor.Create(OpCodes.Callvirt, MakeGenericMethod(invokeSessionEndWithResult, returnType)));
                }

                if (isFinalize)
                {
                    processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldarg_0));
                    processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ldnull));
                }
                if (!method.IsConstructor && !isFinalize)
                {
                    processor.InsertBefore(insertPoint, processor.Create(OpCodes.Ret));
                }

                if (!method.IsConstructor)
                {
                    break;
                }
                insertPoint = findNextRet(method.Body.Instructions, insertPoint);
            }

            if (isFinalize)
            {
                method.Body.ExceptionHandlers[0].TryStart = method.Body.Instructions[0];
            }

            return true;
        }

        public static void OutputIntKeyMapper(Stream output)
        {
            using (StreamWriter writer = new StreamWriter(output))
            {
                writer.WriteLine("return {");
                var data = bridgeIndexByKey
                    .Select((md, idx) => new { Method = md, Index = idx})
                    .GroupBy(info => info.Method.DeclaringType)
                    .ToDictionary(group => group.Key, group =>
                    {
                        return group.GroupBy(info => info.Method.Name).ToDictionary(group_by_name => group_by_name.Key, group_by_name => group_by_name.Select(info => info.Index.ToString()).ToArray());
                    });
                foreach(var kv in data)
                {
                    writer.WriteLine("    [\"" + kv.Key.FullName.Replace('/', '+') + "\"] = {");
                    foreach(var kv2 in kv.Value)
                    {
                        writer.WriteLine("        [\"" + kv2.Key + "\"] = {");
                        writer.WriteLine("            " + string.Join(",", kv2.Value));
                        writer.WriteLine("        },");
                    }
                    writer.WriteLine("    },");
                }
                writer.WriteLine("}");
            }
        }
    }
}
#endif