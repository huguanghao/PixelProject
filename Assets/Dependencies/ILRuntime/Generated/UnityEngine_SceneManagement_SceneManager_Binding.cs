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
    unsafe class UnityEngine_SceneManagement_SceneManager_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.SceneManagement.SceneManager);
            args = new Type[]{typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>)};
            method = type.GetMethod("add_sceneUnloaded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_sceneUnloaded_0);
            args = new Type[]{typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>)};
            method = type.GetMethod("remove_sceneUnloaded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_sceneUnloaded_1);
            args = new Type[]{typeof(UnityEngine.GameObject), typeof(UnityEngine.SceneManagement.Scene)};
            method = type.GetMethod("MoveGameObjectToScene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveGameObjectToScene_2);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetSceneByName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSceneByName_3);
            args = new Type[]{};
            method = type.GetMethod("GetActiveScene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetActiveScene_4);
            args = new Type[]{typeof(UnityEngine.SceneManagement.Scene)};
            method = type.GetMethod("SetActiveScene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetActiveScene_5);


        }


        static StackObject* add_sceneUnloaded_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> @value = (UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>)typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.SceneManagement.SceneManager.sceneUnloaded += value;

            return __ret;
        }

        static StackObject* remove_sceneUnloaded_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> @value = (UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>)typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.SceneManagement.SceneManager.sceneUnloaded -= value;

            return __ret;
        }

        static StackObject* MoveGameObjectToScene_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SceneManagement.Scene @scene = (UnityEngine.SceneManagement.Scene)typeof(UnityEngine.SceneManagement.Scene).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @go = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(@go, @scene);

            return __ret;
        }

        static StackObject* GetSceneByName_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.SceneManagement.SceneManager.GetSceneByName(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetActiveScene_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.SceneManagement.SceneManager.GetActiveScene();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetActiveScene_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SceneManagement.Scene @scene = (UnityEngine.SceneManagement.Scene)typeof(UnityEngine.SceneManagement.Scene).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.SceneManagement.SceneManager.SetActiveScene(@scene);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }



    }
}
