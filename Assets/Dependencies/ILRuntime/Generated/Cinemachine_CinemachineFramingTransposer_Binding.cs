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
    unsafe class Cinemachine_CinemachineFramingTransposer_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Cinemachine.CinemachineFramingTransposer);

            field = type.GetField("m_CameraDistance", flag);
            app.RegisterCLRFieldGetter(field, get_m_CameraDistance_0);
            app.RegisterCLRFieldSetter(field, set_m_CameraDistance_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_CameraDistance_0, AssignFromStack_m_CameraDistance_0);
            field = type.GetField("m_UnlimitedSoftZone", flag);
            app.RegisterCLRFieldGetter(field, get_m_UnlimitedSoftZone_1);
            app.RegisterCLRFieldSetter(field, set_m_UnlimitedSoftZone_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_UnlimitedSoftZone_1, AssignFromStack_m_UnlimitedSoftZone_1);


        }



        static object get_m_CameraDistance_0(ref object o)
        {
            return ((Cinemachine.CinemachineFramingTransposer)o).m_CameraDistance;
        }

        static StackObject* CopyToStack_m_CameraDistance_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Cinemachine.CinemachineFramingTransposer)o).m_CameraDistance;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m_CameraDistance_0(ref object o, object v)
        {
            ((Cinemachine.CinemachineFramingTransposer)o).m_CameraDistance = (System.Single)v;
        }

        static StackObject* AssignFromStack_m_CameraDistance_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m_CameraDistance = *(float*)&ptr_of_this_method->Value;
            ((Cinemachine.CinemachineFramingTransposer)o).m_CameraDistance = @m_CameraDistance;
            return ptr_of_this_method;
        }

        static object get_m_UnlimitedSoftZone_1(ref object o)
        {
            return ((Cinemachine.CinemachineFramingTransposer)o).m_UnlimitedSoftZone;
        }

        static StackObject* CopyToStack_m_UnlimitedSoftZone_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Cinemachine.CinemachineFramingTransposer)o).m_UnlimitedSoftZone;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_m_UnlimitedSoftZone_1(ref object o, object v)
        {
            ((Cinemachine.CinemachineFramingTransposer)o).m_UnlimitedSoftZone = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_m_UnlimitedSoftZone_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @m_UnlimitedSoftZone = ptr_of_this_method->Value == 1;
            ((Cinemachine.CinemachineFramingTransposer)o).m_UnlimitedSoftZone = @m_UnlimitedSoftZone;
            return ptr_of_this_method;
        }



    }
}
