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
    unsafe class UnityEngine_InputSystem_InputActionMap_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.InputActionMap);
            args = new Type[]{typeof(System.String), typeof(System.Boolean)};
            method = type.GetMethod("FindAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindAction_0);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>)};
            method = type.GetMethod("remove_actionTriggered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_actionTriggered_1);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>)};
            method = type.GetMethod("add_actionTriggered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_actionTriggered_2);


        }


        static StackObject* FindAction_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @throwIfNotFound = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @actionNameOrId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.InputActionMap instance_of_this_method = (UnityEngine.InputSystem.InputActionMap)typeof(UnityEngine.InputSystem.InputActionMap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindAction(@actionNameOrId, @throwIfNotFound);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* remove_actionTriggered_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> @value = (System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>)typeof(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputActionMap instance_of_this_method = (UnityEngine.InputSystem.InputActionMap)typeof(UnityEngine.InputSystem.InputActionMap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.actionTriggered -= value;

            return __ret;
        }

        static StackObject* add_actionTriggered_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> @value = (System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>)typeof(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputActionMap instance_of_this_method = (UnityEngine.InputSystem.InputActionMap)typeof(UnityEngine.InputSystem.InputActionMap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.actionTriggered += value;

            return __ret;
        }



    }
}
