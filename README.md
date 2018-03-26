# XIL
使用ILRuntime实现的类似XLUA功能的Unity3D下热修复BUG的解决方案

和XLUA一样的地方
和XLUA原理类似，注入和XLUA基本一致。

不一样的地方
使用C#来进行代码的热更，摆脱LUA，就我自己来说，不喜欢使用LUA来写逻辑。

目录以及文件说明:
Project-
        ----Assets/XIL            --- 所有XIL所用到的文件
	    ----Assets/XIL/ILSource   --- ilRuntime插件源文件，这里的源文件可在git上获取，地址为:https://github.com/Ourpalm/ILRuntime.git
	    ----Assets/XIL/Scripts    --- 注入以及初始化代码
		----Assets/XIL/Auto       --- 自动生成注入的代码以及自动生成的委托和函数的注册
		----Hot                   --- 补丁源文件存放目录
		----Hot.sln               --- 补丁源文件VS解决方案
		----DyncDll.csproj        --- 补丁项目工程文件
		----Data/DyncDll.dll      --- 补丁dll文件
		----Data/DyncDll.pdb      --- 补丁dll的调试文件


使用步骤以及菜单项说明:
*********************************************************************
*         注意：菜单项会根据是否开启热更宏而有所不同                *
*********************************************************************
XIL/插件/开启    --- 开启热补丁宏
XIL/插件/取消    --- 关闭热补丁宏
XIL/插件/PDB开启 --- 加载PDB调试文件
XIL/插件/PDB取消 --- 不加载PDB调试文件

XIL/注册需要热更的类 -- 生成注入所需要的成员接口
XIL/取消需要热更的类 -- 清除注入所需要的成员接口
XIL/委托自动生成     -- 热更当中操作C#层的委托，需要注册委托相关的类型以及转换代码
                        这里可自动分析项目当中所有用到的委托，自动注册

XIL/CLR绑定          -- 作用非反射的方式调用C#层的接口,可大幅度提高运行效率,一些常用的接口可考虑在GenerateCLRBinding
                        文件当中添加需要CLR绑定的类型。

XIL/Hotfix Inject In Editor -- 编辑器下注入接口

只需要两步即可
1 先开启补丁宏
2 注册需要热更的类

初始化以及资源接口
1 需要在项目启动或适当位置调用初始化接口:wxb.hotMgr.Init();
2 非编辑器下，需要自己创建加载文件的接口，可参考编辑器下的资源加载类EditorResLoad。

生成补丁dll
1 打开Hot解决方案
2 调整DyncDll工程依赖UnityEngine.dll以及UnityEngine.UI.dll的路径，默认是我自己u3d软件下的路径
3 编译运行DyncDll工程，编译成功，即可在Data目录下生成补丁库。

如何添加需要热更的类型:
1 使用HotfixAttribute属性宏来修饰类型
2 默认情况下所有类型都会被热更注入，如需要自己调整，可修改源文件ExportIL.cs里，FixMarkIL接口，自定义需要热更的类型

建议：
最好安装下.NET Reflector，可用来反编译被注入的dll,查看源文件，可加深理解XIL的实现原理。
项目下文件Library/ScriptAssemblies/Assembly-CSharp.dll这u3d生成的dll文件，原理上，也是修改此文件实现热更新功能,可使用.NET Reflector进行反编译查看源码

如遇到BUG，可添加QQ:415353522或邮件qewsfs@qq.com联系。