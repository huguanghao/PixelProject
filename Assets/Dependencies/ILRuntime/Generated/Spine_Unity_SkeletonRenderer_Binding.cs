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
    unsafe class Spine_Unity_SkeletonRenderer_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Spine.Unity.SkeletonRenderer);
            args = new Type[]{};
            method = type.GetMethod("ClearState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearState_0);
            args = new Type[]{};
            method = type.GetMethod("get_Skeleton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Skeleton_1);
            args = new Type[]{typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("Initialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialize_2);

            field = type.GetField("skeleton", flag);
            app.RegisterCLRFieldGetter(field, get_skeleton_0);
            app.RegisterCLRFieldSetter(field, set_skeleton_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_skeleton_0, AssignFromStack_skeleton_0);
            field = type.GetField("initialFlipX", flag);
            app.RegisterCLRFieldGetter(field, get_initialFlipX_1);
            app.RegisterCLRFieldSetter(field, set_initialFlipX_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_initialFlipX_1, AssignFromStack_initialFlipX_1);
            field = type.GetField("skeletonDataAsset", flag);
            app.RegisterCLRFieldGetter(field, get_skeletonDataAsset_2);
            app.RegisterCLRFieldSetter(field, set_skeletonDataAsset_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_skeletonDataAsset_2, AssignFromStack_skeletonDataAsset_2);
            field = type.GetField("initialSkinName", flag);
            app.RegisterCLRFieldGetter(field, get_initialSkinName_3);
            app.RegisterCLRFieldSetter(field, set_initialSkinName_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_initialSkinName_3, AssignFromStack_initialSkinName_3);


        }


        static StackObject* ClearState_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Spine.Unity.SkeletonRenderer instance_of_this_method = (Spine.Unity.SkeletonRenderer)typeof(Spine.Unity.SkeletonRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClearState();

            return __ret;
        }

        static StackObject* get_Skeleton_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Spine.Unity.SkeletonRenderer instance_of_this_method = (Spine.Unity.SkeletonRenderer)typeof(Spine.Unity.SkeletonRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Skeleton;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Initialize_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @quiet = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @overwrite = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Spine.Unity.SkeletonRenderer instance_of_this_method = (Spine.Unity.SkeletonRenderer)typeof(Spine.Unity.SkeletonRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialize(@overwrite, @quiet);

            return __ret;
        }


        static object get_skeleton_0(ref object o)
        {
            return ((Spine.Unity.SkeletonRenderer)o).skeleton;
        }

        static StackObject* CopyToStack_skeleton_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Spine.Unity.SkeletonRenderer)o).skeleton;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_skeleton_0(ref object o, object v)
        {
            ((Spine.Unity.SkeletonRenderer)o).skeleton = (Spine.Skeleton)v;
        }

        static StackObject* AssignFromStack_skeleton_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Spine.Skeleton @skeleton = (Spine.Skeleton)typeof(Spine.Skeleton).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Spine.Unity.SkeletonRenderer)o).skeleton = @skeleton;
            return ptr_of_this_method;
        }

        static object get_initialFlipX_1(ref object o)
        {
            return ((Spine.Unity.SkeletonRenderer)o).initialFlipX;
        }

        static StackObject* CopyToStack_initialFlipX_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Spine.Unity.SkeletonRenderer)o).initialFlipX;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_initialFlipX_1(ref object o, object v)
        {
            ((Spine.Unity.SkeletonRenderer)o).initialFlipX = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_initialFlipX_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @initialFlipX = ptr_of_this_method->Value == 1;
            ((Spine.Unity.SkeletonRenderer)o).initialFlipX = @initialFlipX;
            return ptr_of_this_method;
        }

        static object get_skeletonDataAsset_2(ref object o)
        {
            return ((Spine.Unity.SkeletonRenderer)o).skeletonDataAsset;
        }

        static StackObject* CopyToStack_skeletonDataAsset_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Spine.Unity.SkeletonRenderer)o).skeletonDataAsset;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_skeletonDataAsset_2(ref object o, object v)
        {
            ((Spine.Unity.SkeletonRenderer)o).skeletonDataAsset = (Spine.Unity.SkeletonDataAsset)v;
        }

        static StackObject* AssignFromStack_skeletonDataAsset_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Spine.Unity.SkeletonDataAsset @skeletonDataAsset = (Spine.Unity.SkeletonDataAsset)typeof(Spine.Unity.SkeletonDataAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Spine.Unity.SkeletonRenderer)o).skeletonDataAsset = @skeletonDataAsset;
            return ptr_of_this_method;
        }

        static object get_initialSkinName_3(ref object o)
        {
            return ((Spine.Unity.SkeletonRenderer)o).initialSkinName;
        }

        static StackObject* CopyToStack_initialSkinName_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Spine.Unity.SkeletonRenderer)o).initialSkinName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_initialSkinName_3(ref object o, object v)
        {
            ((Spine.Unity.SkeletonRenderer)o).initialSkinName = (System.String)v;
        }

        static StackObject* AssignFromStack_initialSkinName_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @initialSkinName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Spine.Unity.SkeletonRenderer)o).initialSkinName = @initialSkinName;
            return ptr_of_this_method;
        }



    }
}
