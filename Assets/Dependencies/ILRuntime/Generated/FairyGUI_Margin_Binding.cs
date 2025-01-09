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
    unsafe class FairyGUI_Margin_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.Margin);

            field = type.GetField("left", flag);
            app.RegisterCLRFieldGetter(field, get_left_0);
            app.RegisterCLRFieldSetter(field, set_left_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_left_0, AssignFromStack_left_0);
            field = type.GetField("right", flag);
            app.RegisterCLRFieldGetter(field, get_right_1);
            app.RegisterCLRFieldSetter(field, set_right_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_right_1, AssignFromStack_right_1);
            field = type.GetField("top", flag);
            app.RegisterCLRFieldGetter(field, get_top_2);
            app.RegisterCLRFieldSetter(field, set_top_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_top_2, AssignFromStack_top_2);
            field = type.GetField("bottom", flag);
            app.RegisterCLRFieldGetter(field, get_bottom_3);
            app.RegisterCLRFieldSetter(field, set_bottom_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_bottom_3, AssignFromStack_bottom_3);

            app.RegisterCLRCreateDefaultInstance(type, () => new FairyGUI.Margin());


        }

        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref FairyGUI.Margin instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as FairyGUI.Margin[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_left_0(ref object o)
        {
            return ((FairyGUI.Margin)o).left;
        }

        static StackObject* CopyToStack_left_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((FairyGUI.Margin)o).left;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_left_0(ref object o, object v)
        {
            FairyGUI.Margin ins =(FairyGUI.Margin)o;
            ins.left = (System.Int32)v;
            o = ins;
        }

        static StackObject* AssignFromStack_left_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @left = ptr_of_this_method->Value;
            FairyGUI.Margin ins =(FairyGUI.Margin)o;
            ins.left = @left;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_right_1(ref object o)
        {
            return ((FairyGUI.Margin)o).right;
        }

        static StackObject* CopyToStack_right_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((FairyGUI.Margin)o).right;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_right_1(ref object o, object v)
        {
            FairyGUI.Margin ins =(FairyGUI.Margin)o;
            ins.right = (System.Int32)v;
            o = ins;
        }

        static StackObject* AssignFromStack_right_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @right = ptr_of_this_method->Value;
            FairyGUI.Margin ins =(FairyGUI.Margin)o;
            ins.right = @right;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_top_2(ref object o)
        {
            return ((FairyGUI.Margin)o).top;
        }

        static StackObject* CopyToStack_top_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((FairyGUI.Margin)o).top;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_top_2(ref object o, object v)
        {
            FairyGUI.Margin ins =(FairyGUI.Margin)o;
            ins.top = (System.Int32)v;
            o = ins;
        }

        static StackObject* AssignFromStack_top_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @top = ptr_of_this_method->Value;
            FairyGUI.Margin ins =(FairyGUI.Margin)o;
            ins.top = @top;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_bottom_3(ref object o)
        {
            return ((FairyGUI.Margin)o).bottom;
        }

        static StackObject* CopyToStack_bottom_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((FairyGUI.Margin)o).bottom;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_bottom_3(ref object o, object v)
        {
            FairyGUI.Margin ins =(FairyGUI.Margin)o;
            ins.bottom = (System.Int32)v;
            o = ins;
        }

        static StackObject* AssignFromStack_bottom_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @bottom = ptr_of_this_method->Value;
            FairyGUI.Margin ins =(FairyGUI.Margin)o;
            ins.bottom = @bottom;
            o = ins;
            return ptr_of_this_method;
        }



    }
}
