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
    unsafe class YKGame_Runtime_SphereAngleCollider_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(YKGame.Runtime.SphereAngleCollider);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_Layer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Layer_0);

            field = type.GetField("onEnter", flag);
            app.RegisterCLRFieldGetter(field, get_onEnter_0);
            app.RegisterCLRFieldSetter(field, set_onEnter_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_onEnter_0, AssignFromStack_onEnter_0);
            field = type.GetField("onExit", flag);
            app.RegisterCLRFieldGetter(field, get_onExit_1);
            app.RegisterCLRFieldSetter(field, set_onExit_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_onExit_1, AssignFromStack_onExit_1);


        }


        static StackObject* set_Layer_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            YKGame.Runtime.SphereAngleCollider instance_of_this_method = (YKGame.Runtime.SphereAngleCollider)typeof(YKGame.Runtime.SphereAngleCollider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Layer = value;

            return __ret;
        }


        static object get_onEnter_0(ref object o)
        {
            return ((YKGame.Runtime.SphereAngleCollider)o).onEnter;
        }

        static StackObject* CopyToStack_onEnter_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((YKGame.Runtime.SphereAngleCollider)o).onEnter;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_onEnter_0(ref object o, object v)
        {
            ((YKGame.Runtime.SphereAngleCollider)o).onEnter = (System.Action<UnityEngine.Collider>)v;
        }

        static StackObject* AssignFromStack_onEnter_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<UnityEngine.Collider> @onEnter = (System.Action<UnityEngine.Collider>)typeof(System.Action<UnityEngine.Collider>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((YKGame.Runtime.SphereAngleCollider)o).onEnter = @onEnter;
            return ptr_of_this_method;
        }

        static object get_onExit_1(ref object o)
        {
            return ((YKGame.Runtime.SphereAngleCollider)o).onExit;
        }

        static StackObject* CopyToStack_onExit_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((YKGame.Runtime.SphereAngleCollider)o).onExit;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_onExit_1(ref object o, object v)
        {
            ((YKGame.Runtime.SphereAngleCollider)o).onExit = (System.Action<UnityEngine.Collider>)v;
        }

        static StackObject* AssignFromStack_onExit_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<UnityEngine.Collider> @onExit = (System.Action<UnityEngine.Collider>)typeof(System.Action<UnityEngine.Collider>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((YKGame.Runtime.SphereAngleCollider)o).onExit = @onExit;
            return ptr_of_this_method;
        }



    }
}
