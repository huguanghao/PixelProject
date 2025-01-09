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
    unsafe class UnityEngine_AI_NavMeshSurface_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.AI.NavMeshSurface);
            args = new Type[]{typeof(UnityEngine.AI.CollectObjects)};
            method = type.GetMethod("set_collectObjects", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_collectObjects_0);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshCollectGeometry)};
            method = type.GetMethod("set_useGeometry", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useGeometry_1);
            args = new Type[]{};
            method = type.GetMethod("get_navMeshData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_navMeshData_2);
            args = new Type[]{};
            method = type.GetMethod("BuildNavMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BuildNavMesh_3);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshData)};
            method = type.GetMethod("UpdateNavMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateNavMesh_4);


        }


        static StackObject* set_collectObjects_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.CollectObjects @value = (UnityEngine.AI.CollectObjects)typeof(UnityEngine.AI.CollectObjects).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.NavMeshSurface instance_of_this_method = (UnityEngine.AI.NavMeshSurface)typeof(UnityEngine.AI.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.collectObjects = value;

            return __ret;
        }

        static StackObject* set_useGeometry_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshCollectGeometry @value = (UnityEngine.AI.NavMeshCollectGeometry)typeof(UnityEngine.AI.NavMeshCollectGeometry).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.NavMeshSurface instance_of_this_method = (UnityEngine.AI.NavMeshSurface)typeof(UnityEngine.AI.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useGeometry = value;

            return __ret;
        }

        static StackObject* get_navMeshData_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshSurface instance_of_this_method = (UnityEngine.AI.NavMeshSurface)typeof(UnityEngine.AI.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.navMeshData;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BuildNavMesh_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshSurface instance_of_this_method = (UnityEngine.AI.NavMeshSurface)typeof(UnityEngine.AI.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.BuildNavMesh();

            return __ret;
        }

        static StackObject* UpdateNavMesh_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshData @data = (UnityEngine.AI.NavMeshData)typeof(UnityEngine.AI.NavMeshData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.NavMeshSurface instance_of_this_method = (UnityEngine.AI.NavMeshSurface)typeof(UnityEngine.AI.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.UpdateNavMesh(@data);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}
