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
    unsafe class Cinemachine_CinemachineOrthographicSizeDamper_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Cinemachine.CinemachineOrthographicSizeDamper);

            field = type.GetField("orthographicSize", flag);
            app.RegisterCLRFieldGetter(field, get_orthographicSize_0);
            app.RegisterCLRFieldSetter(field, set_orthographicSize_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_orthographicSize_0, AssignFromStack_orthographicSize_0);
            field = type.GetField("m_Max", flag);
            app.RegisterCLRFieldGetter(field, get_m_Max_1);
            app.RegisterCLRFieldSetter(field, set_m_Max_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_Max_1, AssignFromStack_m_Max_1);
            field = type.GetField("m_Min", flag);
            app.RegisterCLRFieldGetter(field, get_m_Min_2);
            app.RegisterCLRFieldSetter(field, set_m_Min_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_Min_2, AssignFromStack_m_Min_2);
            field = type.GetField("m_Damping", flag);
            app.RegisterCLRFieldGetter(field, get_m_Damping_3);
            app.RegisterCLRFieldSetter(field, set_m_Damping_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_Damping_3, AssignFromStack_m_Damping_3);


        }



        static object get_orthographicSize_0(ref object o)
        {
            return ((Cinemachine.CinemachineOrthographicSizeDamper)o).orthographicSize;
        }

        static StackObject* CopyToStack_orthographicSize_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Cinemachine.CinemachineOrthographicSizeDamper)o).orthographicSize;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_orthographicSize_0(ref object o, object v)
        {
            ((Cinemachine.CinemachineOrthographicSizeDamper)o).orthographicSize = (System.Single)v;
        }

        static StackObject* AssignFromStack_orthographicSize_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @orthographicSize = *(float*)&ptr_of_this_method->Value;
            ((Cinemachine.CinemachineOrthographicSizeDamper)o).orthographicSize = @orthographicSize;
            return ptr_of_this_method;
        }

        static object get_m_Max_1(ref object o)
        {
            return ((Cinemachine.CinemachineOrthographicSizeDamper)o).m_Max;
        }

        static StackObject* CopyToStack_m_Max_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Cinemachine.CinemachineOrthographicSizeDamper)o).m_Max;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m_Max_1(ref object o, object v)
        {
            ((Cinemachine.CinemachineOrthographicSizeDamper)o).m_Max = (System.Single)v;
        }

        static StackObject* AssignFromStack_m_Max_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m_Max = *(float*)&ptr_of_this_method->Value;
            ((Cinemachine.CinemachineOrthographicSizeDamper)o).m_Max = @m_Max;
            return ptr_of_this_method;
        }

        static object get_m_Min_2(ref object o)
        {
            return ((Cinemachine.CinemachineOrthographicSizeDamper)o).m_Min;
        }

        static StackObject* CopyToStack_m_Min_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Cinemachine.CinemachineOrthographicSizeDamper)o).m_Min;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m_Min_2(ref object o, object v)
        {
            ((Cinemachine.CinemachineOrthographicSizeDamper)o).m_Min = (System.Single)v;
        }

        static StackObject* AssignFromStack_m_Min_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m_Min = *(float*)&ptr_of_this_method->Value;
            ((Cinemachine.CinemachineOrthographicSizeDamper)o).m_Min = @m_Min;
            return ptr_of_this_method;
        }

        static object get_m_Damping_3(ref object o)
        {
            return ((Cinemachine.CinemachineOrthographicSizeDamper)o).m_Damping;
        }

        static StackObject* CopyToStack_m_Damping_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Cinemachine.CinemachineOrthographicSizeDamper)o).m_Damping;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_m_Damping_3(ref object o, object v)
        {
            ((Cinemachine.CinemachineOrthographicSizeDamper)o).m_Damping = (System.Single)v;
        }

        static StackObject* AssignFromStack_m_Damping_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @m_Damping = *(float*)&ptr_of_this_method->Value;
            ((Cinemachine.CinemachineOrthographicSizeDamper)o).m_Damping = @m_Damping;
            return ptr_of_this_method;
        }



    }
}
