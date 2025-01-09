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
    unsafe class YKGame_Runtime_GridDirection_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(YKGame.Runtime.GridDirection);

            field = type.GetField("SouthWest", flag);
            app.RegisterCLRFieldGetter(field, get_SouthWest_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_SouthWest_0, null);
            field = type.GetField("Vector", flag);
            app.RegisterCLRFieldGetter(field, get_Vector_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Vector_1, null);


        }



        static object get_SouthWest_0(ref object o)
        {
            return YKGame.Runtime.GridDirection.SouthWest;
        }

        static StackObject* CopyToStack_SouthWest_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = YKGame.Runtime.GridDirection.SouthWest;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Vector_1(ref object o)
        {
            return ((YKGame.Runtime.GridDirection)o).Vector;
        }

        static StackObject* CopyToStack_Vector_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((YKGame.Runtime.GridDirection)o).Vector;
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }



    }
}
