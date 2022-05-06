using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace wxb
{
    public static partial class ConstString
    {
        // ���п����л����ֶ���
        static string[] FieldNames = null;
        static Dictionary<string, short> Indexs = null;

        public static void Set(string[] fieldNames)
        {
            FieldNames = fieldNames;
            if (Indexs == null)
                Indexs = new Dictionary<string, short>();
            else
                Indexs.Clear();

            short cnt = (short)fieldNames.Length;
            for (short i = 0; i < cnt; ++i)
                Indexs.Add(fieldNames[i], i);
        }

        public static string GetName(int id)
        {
            try
            {
                return FieldNames[id];
            }
            catch (System.Exception ex)
            {
                L.LogError($"���л����ֶ�����:{id}���Ҷ�Ӧ�ֶ���ʧ��!");
                throw ex;
            }
        }

        public static bool TryGetIndex(string name, out short index)
        {
            return Indexs.TryGetValue(name, out index);
        }

        public static short GetIndex(string name)
        {
            if (Indexs.TryGetValue(name, out var index))
                return index;

            L.LogError($"���л����ֶ���:{name}���Ҷ�Ӧ�ֶ�����ʧ��!");
            throw new System.MissingFieldException($"�ֶ���:{name}��Ӧ�ֶ���������ʧ��!");
        }

        public static void Init(System.IO.Stream stream)
        {
            System.IO.BinaryReader reader = new System.IO.BinaryReader(stream);
            short cnt = reader.ReadInt16();
            string[] names = new string[cnt];
            for (int i = 0; i < cnt; ++i)
                names[i] = reader.ReadString();
            Set(names);
        }
    }
}