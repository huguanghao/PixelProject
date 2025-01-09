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
    unsafe class YKGame_Runtime_ScaleMatch_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(YKGame.Runtime.ScaleMatch);

            field = type.GetField("height", flag);
            app.RegisterCLRFieldGetter(field, get_height_0);
            app.RegisterCLRFieldSetter(field, set_height_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_height_0, AssignFromStack_height_0);


        }



        static object get_height_0(ref object o)
        {
            return ((YKGame.Runtime.ScaleMatch)o).height;
        }

        static StackObject* CopyToStack_height_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((YKGame.Runtime.ScaleMatch)o).height;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_height_0(ref object o, object v)
        {
            ((YKGame.Runtime.ScaleMatch)o).height = (System.Single)v;
        }

        static StackObject* AssignFromStack_height_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @height = *(float*)&ptr_of_this_method->Value;
            ((YKGame.Runtime.ScaleMatch)o).height = @height;
            return ptr_of_this_method;
        }



    }
}
