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
    unsafe class FairyGUI_GObjectPool_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.GObjectPool);
            args = new Type[]{typeof(FairyGUI.GObject)};
            method = type.GetMethod("ReturnObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReturnObject_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetObject_1);

            field = type.GetField("initCallback", flag);
            app.RegisterCLRFieldGetter(field, get_initCallback_0);
            app.RegisterCLRFieldSetter(field, set_initCallback_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_initCallback_0, AssignFromStack_initCallback_0);

            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* ReturnObject_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.GObject @obj = (FairyGUI.GObject)typeof(FairyGUI.GObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.GObjectPool instance_of_this_method = (FairyGUI.GObjectPool)typeof(FairyGUI.GObjectPool).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReturnObject(@obj);

            return __ret;
        }

        static StackObject* GetObject_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @url = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.GObjectPool instance_of_this_method = (FairyGUI.GObjectPool)typeof(FairyGUI.GObjectPool).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetObject(@url);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_initCallback_0(ref object o)
        {
            return ((FairyGUI.GObjectPool)o).initCallback;
        }

        static StackObject* CopyToStack_initCallback_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((FairyGUI.GObjectPool)o).initCallback;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_initCallback_0(ref object o, object v)
        {
            ((FairyGUI.GObjectPool)o).initCallback = (FairyGUI.GObjectPool.InitCallbackDelegate)v;
        }

        static StackObject* AssignFromStack_initCallback_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            FairyGUI.GObjectPool.InitCallbackDelegate @initCallback = (FairyGUI.GObjectPool.InitCallbackDelegate)typeof(FairyGUI.GObjectPool.InitCallbackDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((FairyGUI.GObjectPool)o).initCallback = @initCallback;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @manager = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new FairyGUI.GObjectPool(@manager);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
