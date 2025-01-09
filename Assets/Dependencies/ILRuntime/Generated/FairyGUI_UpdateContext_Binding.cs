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
    unsafe class FairyGUI_UpdateContext_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.UpdateContext);

            field = type.GetField("alpha", flag);
            app.RegisterCLRFieldGetter(field, get_alpha_0);
            app.RegisterCLRFieldSetter(field, set_alpha_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_alpha_0, AssignFromStack_alpha_0);


        }



        static object get_alpha_0(ref object o)
        {
            return ((FairyGUI.UpdateContext)o).alpha;
        }

        static StackObject* CopyToStack_alpha_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((FairyGUI.UpdateContext)o).alpha;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_alpha_0(ref object o, object v)
        {
            ((FairyGUI.UpdateContext)o).alpha = (System.Single)v;
        }

        static StackObject* AssignFromStack_alpha_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @alpha = *(float*)&ptr_of_this_method->Value;
            ((FairyGUI.UpdateContext)o).alpha = @alpha;
            return ptr_of_this_method;
        }



    }
}
