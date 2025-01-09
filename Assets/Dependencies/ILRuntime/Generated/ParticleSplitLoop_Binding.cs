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
    unsafe class ParticleSplitLoop_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::ParticleSplitLoop);

            field = type.GetField("duration", flag);
            app.RegisterCLRFieldGetter(field, get_duration_0);
            app.RegisterCLRFieldSetter(field, set_duration_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_duration_0, AssignFromStack_duration_0);


        }



        static object get_duration_0(ref object o)
        {
            return ((global::ParticleSplitLoop)o).duration;
        }

        static StackObject* CopyToStack_duration_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::ParticleSplitLoop)o).duration;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_duration_0(ref object o, object v)
        {
            ((global::ParticleSplitLoop)o).duration = (System.Single)v;
        }

        static StackObject* AssignFromStack_duration_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @duration = *(float*)&ptr_of_this_method->Value;
            ((global::ParticleSplitLoop)o).duration = @duration;
            return ptr_of_this_method;
        }



    }
}
