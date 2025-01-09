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
    unsafe class Cinemachine_CinemachineBrain_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Cinemachine.CinemachineBrain);
            args = new Type[]{};
            method = type.GetMethod("get_OutputCamera", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_OutputCamera_0);
            args = new Type[]{};
            method = type.GetMethod("get_ActiveVirtualCamera", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ActiveVirtualCamera_1);
            args = new Type[]{};
            method = type.GetMethod("get_IsBlending", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsBlending_2);
            args = new Type[]{};
            method = type.GetMethod("ManualUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ManualUpdate_3);
            args = new Type[]{};
            method = type.GetMethod("get_DefaultWorldUp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DefaultWorldUp_4);

            field = type.GetField("m_UpdateMethod", flag);
            app.RegisterCLRFieldGetter(field, get_m_UpdateMethod_0);
            app.RegisterCLRFieldSetter(field, set_m_UpdateMethod_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_UpdateMethod_0, AssignFromStack_m_UpdateMethod_0);
            field = type.GetField("m_DefaultBlend", flag);
            app.RegisterCLRFieldGetter(field, get_m_DefaultBlend_1);
            app.RegisterCLRFieldSetter(field, set_m_DefaultBlend_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_DefaultBlend_1, AssignFromStack_m_DefaultBlend_1);
            field = type.GetField("m_CameraActivatedEvent", flag);
            app.RegisterCLRFieldGetter(field, get_m_CameraActivatedEvent_2);
            app.RegisterCLRFieldSetter(field, set_m_CameraActivatedEvent_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_CameraActivatedEvent_2, AssignFromStack_m_CameraActivatedEvent_2);


        }


        static StackObject* get_OutputCamera_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Cinemachine.CinemachineBrain instance_of_this_method = (Cinemachine.CinemachineBrain)typeof(Cinemachine.CinemachineBrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.OutputCamera;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_ActiveVirtualCamera_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Cinemachine.CinemachineBrain instance_of_this_method = (Cinemachine.CinemachineBrain)typeof(Cinemachine.CinemachineBrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ActiveVirtualCamera;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_IsBlending_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Cinemachine.CinemachineBrain instance_of_this_method = (Cinemachine.CinemachineBrain)typeof(Cinemachine.CinemachineBrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsBlending;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ManualUpdate_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Cinemachine.CinemachineBrain instance_of_this_method = (Cinemachine.CinemachineBrain)typeof(Cinemachine.CinemachineBrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ManualUpdate();

            return __ret;
        }

        static StackObject* get_DefaultWorldUp_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Cinemachine.CinemachineBrain instance_of_this_method = (Cinemachine.CinemachineBrain)typeof(Cinemachine.CinemachineBrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DefaultWorldUp;

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }


        static object get_m_UpdateMethod_0(ref object o)
        {
            return ((Cinemachine.CinemachineBrain)o).m_UpdateMethod;
        }

        static StackObject* CopyToStack_m_UpdateMethod_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Cinemachine.CinemachineBrain)o).m_UpdateMethod;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_UpdateMethod_0(ref object o, object v)
        {
            ((Cinemachine.CinemachineBrain)o).m_UpdateMethod = (Cinemachine.CinemachineBrain.UpdateMethod)v;
        }

        static StackObject* AssignFromStack_m_UpdateMethod_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Cinemachine.CinemachineBrain.UpdateMethod @m_UpdateMethod = (Cinemachine.CinemachineBrain.UpdateMethod)typeof(Cinemachine.CinemachineBrain.UpdateMethod).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Cinemachine.CinemachineBrain)o).m_UpdateMethod = @m_UpdateMethod;
            return ptr_of_this_method;
        }

        static object get_m_DefaultBlend_1(ref object o)
        {
            return ((Cinemachine.CinemachineBrain)o).m_DefaultBlend;
        }

        static StackObject* CopyToStack_m_DefaultBlend_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Cinemachine.CinemachineBrain)o).m_DefaultBlend;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_DefaultBlend_1(ref object o, object v)
        {
            ((Cinemachine.CinemachineBrain)o).m_DefaultBlend = (Cinemachine.CinemachineBlendDefinition)v;
        }

        static StackObject* AssignFromStack_m_DefaultBlend_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Cinemachine.CinemachineBlendDefinition @m_DefaultBlend = (Cinemachine.CinemachineBlendDefinition)typeof(Cinemachine.CinemachineBlendDefinition).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Cinemachine.CinemachineBrain)o).m_DefaultBlend = @m_DefaultBlend;
            return ptr_of_this_method;
        }

        static object get_m_CameraActivatedEvent_2(ref object o)
        {
            return ((Cinemachine.CinemachineBrain)o).m_CameraActivatedEvent;
        }

        static StackObject* CopyToStack_m_CameraActivatedEvent_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Cinemachine.CinemachineBrain)o).m_CameraActivatedEvent;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_CameraActivatedEvent_2(ref object o, object v)
        {
            ((Cinemachine.CinemachineBrain)o).m_CameraActivatedEvent = (Cinemachine.CinemachineBrain.VcamActivatedEvent)v;
        }

        static StackObject* AssignFromStack_m_CameraActivatedEvent_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Cinemachine.CinemachineBrain.VcamActivatedEvent @m_CameraActivatedEvent = (Cinemachine.CinemachineBrain.VcamActivatedEvent)typeof(Cinemachine.CinemachineBrain.VcamActivatedEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Cinemachine.CinemachineBrain)o).m_CameraActivatedEvent = @m_CameraActivatedEvent;
            return ptr_of_this_method;
        }



    }
}
