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
    unsafe class FairyGUI_Container_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.Container);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_onUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onUpdate_0);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_onUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onUpdate_1);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_fairyBatching", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fairyBatching_2);

            field = type.GetField("renderMode", flag);
            app.RegisterCLRFieldGetter(field, get_renderMode_0);
            app.RegisterCLRFieldSetter(field, set_renderMode_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_renderMode_0, AssignFromStack_renderMode_0);


        }


        static StackObject* add_onUpdate_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.Container instance_of_this_method = (FairyGUI.Container)typeof(FairyGUI.Container).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onUpdate += value;

            return __ret;
        }

        static StackObject* remove_onUpdate_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.Container instance_of_this_method = (FairyGUI.Container)typeof(FairyGUI.Container).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onUpdate -= value;

            return __ret;
        }

        static StackObject* set_fairyBatching_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.Container instance_of_this_method = (FairyGUI.Container)typeof(FairyGUI.Container).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.fairyBatching = value;

            return __ret;
        }


        static object get_renderMode_0(ref object o)
        {
            return ((FairyGUI.Container)o).renderMode;
        }

        static StackObject* CopyToStack_renderMode_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((FairyGUI.Container)o).renderMode;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_renderMode_0(ref object o, object v)
        {
            ((FairyGUI.Container)o).renderMode = (UnityEngine.RenderMode)v;
        }

        static StackObject* AssignFromStack_renderMode_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.RenderMode @renderMode = (UnityEngine.RenderMode)typeof(UnityEngine.RenderMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((FairyGUI.Container)o).renderMode = @renderMode;
            return ptr_of_this_method;
        }



    }
}
