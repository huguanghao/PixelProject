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
    unsafe class Cinemachine_CinemachineConfiner_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Cinemachine.CinemachineConfiner);

            field = type.GetField("m_BoundingVolume", flag);
            app.RegisterCLRFieldGetter(field, get_m_BoundingVolume_0);
            app.RegisterCLRFieldSetter(field, set_m_BoundingVolume_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_BoundingVolume_0, AssignFromStack_m_BoundingVolume_0);


        }



        static object get_m_BoundingVolume_0(ref object o)
        {
            return ((Cinemachine.CinemachineConfiner)o).m_BoundingVolume;
        }

        static StackObject* CopyToStack_m_BoundingVolume_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Cinemachine.CinemachineConfiner)o).m_BoundingVolume;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_BoundingVolume_0(ref object o, object v)
        {
            ((Cinemachine.CinemachineConfiner)o).m_BoundingVolume = (UnityEngine.Collider)v;
        }

        static StackObject* AssignFromStack_m_BoundingVolume_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Collider @m_BoundingVolume = (UnityEngine.Collider)typeof(UnityEngine.Collider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Cinemachine.CinemachineConfiner)o).m_BoundingVolume = @m_BoundingVolume;
            return ptr_of_this_method;
        }



    }
}
