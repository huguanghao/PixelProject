using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace ILRuntime.Runtime.Generated
{
    unsafe class YKGame_Runtime_UIAssets_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(YKGame.Runtime.UIAssets);
            args = new Type[]{};
            method = type.GetMethod("get_Package", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Package_0);

            field = type.GetField("PackageName", flag);
            app.RegisterCLRFieldGetter(field, get_PackageName_0);
            app.RegisterCLRFieldSetter(field, set_PackageName_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_PackageName_0, AssignFromStack_PackageName_0);


        }


        static StackObject* get_Package_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            YKGame.Runtime.UIAssets instance_of_this_method = (YKGame.Runtime.UIAssets)typeof(YKGame.Runtime.UIAssets).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Package;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_PackageName_0(ref object o)
        {
            return ((YKGame.Runtime.UIAssets)o).PackageName;
        }

        static StackObject* CopyToStack_PackageName_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((YKGame.Runtime.UIAssets)o).PackageName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PackageName_0(ref object o, object v)
        {
            ((YKGame.Runtime.UIAssets)o).PackageName = (System.String)v;
        }

        static StackObject* AssignFromStack_PackageName_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @PackageName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((YKGame.Runtime.UIAssets)o).PackageName = @PackageName;
            return ptr_of_this_method;
        }



    }
}
