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
    unsafe class Cinemachine_CinemachineConfinerController_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Cinemachine.CinemachineConfinerController);
            args = new Type[]{typeof(global::MapSetting)};
            method = type.GetMethod("Init", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Init_0);

            field = type.GetField("m_BoundingVolume", flag);
            app.RegisterCLRFieldGetter(field, get_m_BoundingVolume_0);
            app.RegisterCLRFieldSetter(field, set_m_BoundingVolume_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_BoundingVolume_0, AssignFromStack_m_BoundingVolume_0);


        }


        static StackObject* Init_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::MapSetting @newMap = (global::MapSetting)typeof(global::MapSetting).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Cinemachine.CinemachineConfinerController instance_of_this_method = (Cinemachine.CinemachineConfinerController)typeof(Cinemachine.CinemachineConfinerController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Init(@newMap);

            return __ret;
        }


        static object get_m_BoundingVolume_0(ref object o)
        {
            return ((Cinemachine.CinemachineConfinerController)o).m_BoundingVolume;
        }

        static StackObject* CopyToStack_m_BoundingVolume_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Cinemachine.CinemachineConfinerController)o).m_BoundingVolume;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_BoundingVolume_0(ref object o, object v)
        {
            ((Cinemachine.CinemachineConfinerController)o).m_BoundingVolume = (UnityEngine.BoxCollider)v;
        }

        static StackObject* AssignFromStack_m_BoundingVolume_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.BoxCollider @m_BoundingVolume = (UnityEngine.BoxCollider)typeof(UnityEngine.BoxCollider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Cinemachine.CinemachineConfinerController)o).m_BoundingVolume = @m_BoundingVolume;
            return ptr_of_this_method;
        }



    }
}
