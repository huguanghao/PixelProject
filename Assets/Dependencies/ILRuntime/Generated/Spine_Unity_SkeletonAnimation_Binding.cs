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
    unsafe class Spine_Unity_SkeletonAnimation_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Spine.Unity.SkeletonAnimation);
            args = new Type[]{};
            method = type.GetMethod("get_AnimationName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AnimationName_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_AnimationName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_AnimationName_1);
            args = new Type[]{};
            method = type.GetMethod("get_AnimationState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AnimationState_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("Update", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Update_3);
            args = new Type[]{};
            method = type.GetMethod("get_UnscaledTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_UnscaledTime_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_UnscaledTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_UnscaledTime_5);

            field = type.GetField("loop", flag);
            app.RegisterCLRFieldGetter(field, get_loop_0);
            app.RegisterCLRFieldSetter(field, set_loop_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_loop_0, AssignFromStack_loop_0);


        }


        static StackObject* get_AnimationName_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Spine.Unity.SkeletonAnimation instance_of_this_method = (Spine.Unity.SkeletonAnimation)typeof(Spine.Unity.SkeletonAnimation).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AnimationName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_AnimationName_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Spine.Unity.SkeletonAnimation instance_of_this_method = (Spine.Unity.SkeletonAnimation)typeof(Spine.Unity.SkeletonAnimation).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AnimationName = value;

            return __ret;
        }

        static StackObject* get_AnimationState_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Spine.Unity.SkeletonAnimation instance_of_this_method = (Spine.Unity.SkeletonAnimation)typeof(Spine.Unity.SkeletonAnimation).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AnimationState;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Update_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @deltaTime = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Spine.Unity.SkeletonAnimation instance_of_this_method = (Spine.Unity.SkeletonAnimation)typeof(Spine.Unity.SkeletonAnimation).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Update(@deltaTime);

            return __ret;
        }

        static StackObject* get_UnscaledTime_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Spine.Unity.SkeletonAnimation instance_of_this_method = (Spine.Unity.SkeletonAnimation)typeof(Spine.Unity.SkeletonAnimation).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.UnscaledTime;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_UnscaledTime_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Spine.Unity.SkeletonAnimation instance_of_this_method = (Spine.Unity.SkeletonAnimation)typeof(Spine.Unity.SkeletonAnimation).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UnscaledTime = value;

            return __ret;
        }


        static object get_loop_0(ref object o)
        {
            return ((Spine.Unity.SkeletonAnimation)o).loop;
        }

        static StackObject* CopyToStack_loop_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Spine.Unity.SkeletonAnimation)o).loop;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_loop_0(ref object o, object v)
        {
            ((Spine.Unity.SkeletonAnimation)o).loop = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_loop_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @loop = ptr_of_this_method->Value == 1;
            ((Spine.Unity.SkeletonAnimation)o).loop = @loop;
            return ptr_of_this_method;
        }



    }
}
