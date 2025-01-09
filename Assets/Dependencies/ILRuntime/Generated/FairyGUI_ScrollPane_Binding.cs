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
    unsafe class FairyGUI_ScrollPane_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.ScrollPane);
            args = new Type[]{typeof(System.Single), typeof(System.Boolean)};
            method = type.GetMethod("SetPercY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPercY_0);
            args = new Type[]{};
            method = type.GetMethod("get_onScroll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onScroll_1);
            args = new Type[]{};
            method = type.GetMethod("get_draggingPane", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_draggingPane_2);
            args = new Type[]{};
            method = type.GetMethod("get_owner", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_owner_3);
            args = new Type[]{};
            method = type.GetMethod("get_contentHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_contentHeight_4);
            args = new Type[]{};
            method = type.GetMethod("get_percY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_percY_5);
            args = new Type[]{};
            method = type.GetMethod("get_isDragged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isDragged_6);

            field = type.GetField("TWEEN_TIME_GO", flag);
            app.RegisterCLRFieldGetter(field, get_TWEEN_TIME_GO_0);
            app.RegisterCLRFieldSetter(field, set_TWEEN_TIME_GO_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_TWEEN_TIME_GO_0, AssignFromStack_TWEEN_TIME_GO_0);


        }


        static StackObject* SetPercY_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPercY(@value, @ani);

            return __ret;
        }

        static StackObject* get_onScroll_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onScroll;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_draggingPane_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = FairyGUI.ScrollPane.draggingPane;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_owner_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.owner;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_contentHeight_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.contentHeight;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_percY_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.percY;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_isDragged_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isDragged;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_TWEEN_TIME_GO_0(ref object o)
        {
            return FairyGUI.ScrollPane.TWEEN_TIME_GO;
        }

        static StackObject* CopyToStack_TWEEN_TIME_GO_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = FairyGUI.ScrollPane.TWEEN_TIME_GO;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_TWEEN_TIME_GO_0(ref object o, object v)
        {
            FairyGUI.ScrollPane.TWEEN_TIME_GO = (System.Single)v;
        }

        static StackObject* AssignFromStack_TWEEN_TIME_GO_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @TWEEN_TIME_GO = *(float*)&ptr_of_this_method->Value;
            FairyGUI.ScrollPane.TWEEN_TIME_GO = @TWEEN_TIME_GO;
            return ptr_of_this_method;
        }



    }
}
