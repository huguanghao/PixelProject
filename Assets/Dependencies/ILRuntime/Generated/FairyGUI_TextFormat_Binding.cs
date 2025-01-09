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
    unsafe class FairyGUI_TextFormat_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.TextFormat);

            field = type.GetField("size", flag);
            app.RegisterCLRFieldGetter(field, get_size_0);
            app.RegisterCLRFieldSetter(field, set_size_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_size_0, AssignFromStack_size_0);


        }



        static object get_size_0(ref object o)
        {
            return ((FairyGUI.TextFormat)o).size;
        }

        static StackObject* CopyToStack_size_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((FairyGUI.TextFormat)o).size;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_size_0(ref object o, object v)
        {
            ((FairyGUI.TextFormat)o).size = (System.Int32)v;
        }

        static StackObject* AssignFromStack_size_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @size = ptr_of_this_method->Value;
            ((FairyGUI.TextFormat)o).size = @size;
            return ptr_of_this_method;
        }



    }
}
