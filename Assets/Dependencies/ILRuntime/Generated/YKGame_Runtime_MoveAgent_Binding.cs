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
    unsafe class YKGame_Runtime_MoveAgent_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(YKGame.Runtime.MoveAgent);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_Layer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Layer_0);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("SetFollowTargetOnArrived", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetFollowTargetOnArrived_1);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("SetFollowTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetFollowTarget_2);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(System.Boolean)};
            method = type.GetMethod("SetLockVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLockVelocity_3);

            field = type.GetField("rigid", flag);
            app.RegisterCLRFieldGetter(field, get_rigid_0);
            app.RegisterCLRFieldSetter(field, set_rigid_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_rigid_0, AssignFromStack_rigid_0);
            field = type.GetField("agent", flag);
            app.RegisterCLRFieldGetter(field, get_agent_1);
            app.RegisterCLRFieldSetter(field, set_agent_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_agent_1, AssignFromStack_agent_1);
            field = type.GetField("moveDirection", flag);
            app.RegisterCLRFieldGetter(field, get_moveDirection_2);
            app.RegisterCLRFieldSetter(field, set_moveDirection_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_moveDirection_2, AssignFromStack_moveDirection_2);
            field = type.GetField("customAgentVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_customAgentVelocity_3);
            app.RegisterCLRFieldSetter(field, set_customAgentVelocity_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_customAgentVelocity_3, AssignFromStack_customAgentVelocity_3);


        }


        static StackObject* set_Layer_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            YKGame.Runtime.MoveAgent instance_of_this_method = (YKGame.Runtime.MoveAgent)typeof(YKGame.Runtime.MoveAgent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Layer = value;

            return __ret;
        }

        static StackObject* SetFollowTargetOnArrived_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @target = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            YKGame.Runtime.MoveAgent instance_of_this_method = (YKGame.Runtime.MoveAgent)typeof(YKGame.Runtime.MoveAgent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetFollowTargetOnArrived(@target);

            return __ret;
        }

        static StackObject* SetFollowTarget_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @target = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            YKGame.Runtime.MoveAgent instance_of_this_method = (YKGame.Runtime.MoveAgent)typeof(YKGame.Runtime.MoveAgent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetFollowTarget(@target);

            return __ret;
        }

        static StackObject* SetLockVelocity_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @setLock = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @velocity = new UnityEngine.Vector3();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @velocity, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @velocity = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            YKGame.Runtime.MoveAgent instance_of_this_method = (YKGame.Runtime.MoveAgent)typeof(YKGame.Runtime.MoveAgent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLockVelocity(@velocity, @setLock);

            return __ret;
        }


        static object get_rigid_0(ref object o)
        {
            return ((YKGame.Runtime.MoveAgent)o).rigid;
        }

        static StackObject* CopyToStack_rigid_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((YKGame.Runtime.MoveAgent)o).rigid;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_rigid_0(ref object o, object v)
        {
            ((YKGame.Runtime.MoveAgent)o).rigid = (UnityEngine.Rigidbody)v;
        }

        static StackObject* AssignFromStack_rigid_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Rigidbody @rigid = (UnityEngine.Rigidbody)typeof(UnityEngine.Rigidbody).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((YKGame.Runtime.MoveAgent)o).rigid = @rigid;
            return ptr_of_this_method;
        }

        static object get_agent_1(ref object o)
        {
            return ((YKGame.Runtime.MoveAgent)o).agent;
        }

        static StackObject* CopyToStack_agent_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((YKGame.Runtime.MoveAgent)o).agent;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_agent_1(ref object o, object v)
        {
            ((YKGame.Runtime.MoveAgent)o).agent = (UnityEngine.AI.NavMeshAgent)v;
        }

        static StackObject* AssignFromStack_agent_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.AI.NavMeshAgent @agent = (UnityEngine.AI.NavMeshAgent)typeof(UnityEngine.AI.NavMeshAgent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((YKGame.Runtime.MoveAgent)o).agent = @agent;
            return ptr_of_this_method;
        }

        static object get_moveDirection_2(ref object o)
        {
            return ((YKGame.Runtime.MoveAgent)o).moveDirection;
        }

        static StackObject* CopyToStack_moveDirection_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((YKGame.Runtime.MoveAgent)o).moveDirection;
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static void set_moveDirection_2(ref object o, object v)
        {
            ((YKGame.Runtime.MoveAgent)o).moveDirection = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_moveDirection_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @moveDirection = new UnityEngine.Vector3();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @moveDirection, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @moveDirection = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }
            ((YKGame.Runtime.MoveAgent)o).moveDirection = @moveDirection;
            return ptr_of_this_method;
        }

        static object get_customAgentVelocity_3(ref object o)
        {
            return ((YKGame.Runtime.MoveAgent)o).customAgentVelocity;
        }

        static StackObject* CopyToStack_customAgentVelocity_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((YKGame.Runtime.MoveAgent)o).customAgentVelocity;
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static void set_customAgentVelocity_3(ref object o, object v)
        {
            ((YKGame.Runtime.MoveAgent)o).customAgentVelocity = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_customAgentVelocity_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @customAgentVelocity = new UnityEngine.Vector3();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @customAgentVelocity, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @customAgentVelocity = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }
            ((YKGame.Runtime.MoveAgent)o).customAgentVelocity = @customAgentVelocity;
            return ptr_of_this_method;
        }



    }
}
