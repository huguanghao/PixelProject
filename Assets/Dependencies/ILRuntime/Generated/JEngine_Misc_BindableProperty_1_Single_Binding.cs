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
    unsafe class JEngine_Misc_BindableProperty_1_Single_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(JEngine.Misc.BindableProperty<System.Single>);
            args = new Type[]{typeof(JEngine.Misc.BindableProperty<System.Single>)};
            method = type.GetMethod("op_Implicit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, op_Implicit_0);
            args = new Type[]{};
            method = type.GetMethod("get_Value", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Value_1);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_Value", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Value_2);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_3);

            field = type.GetField("OnChangeWithOldVal", flag);
            app.RegisterCLRFieldGetter(field, get_OnChangeWithOldVal_0);
            app.RegisterCLRFieldSetter(field, set_OnChangeWithOldVal_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnChangeWithOldVal_0, AssignFromStack_OnChangeWithOldVal_0);
            field = type.GetField("OnChange", flag);
            app.RegisterCLRFieldGetter(field, get_OnChange_1);
            app.RegisterCLRFieldSetter(field, set_OnChange_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnChange_1, AssignFromStack_OnChange_1);

            args = new Type[]{typeof(System.Single)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* op_Implicit_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            JEngine.Misc.BindableProperty<System.Single> @t = (JEngine.Misc.BindableProperty<System.Single>)typeof(JEngine.Misc.BindableProperty<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = (System.Single)t;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_Value_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            JEngine.Misc.BindableProperty<System.Single> instance_of_this_method = (JEngine.Misc.BindableProperty<System.Single>)typeof(JEngine.Misc.BindableProperty<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Value;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_Value_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            JEngine.Misc.BindableProperty<System.Single> instance_of_this_method = (JEngine.Misc.BindableProperty<System.Single>)typeof(JEngine.Misc.BindableProperty<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Value = value;

            return __ret;
        }

        static StackObject* Clear_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            JEngine.Misc.BindableProperty<System.Single> instance_of_this_method = (JEngine.Misc.BindableProperty<System.Single>)typeof(JEngine.Misc.BindableProperty<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }


        static object get_OnChangeWithOldVal_0(ref object o)
        {
            return ((JEngine.Misc.BindableProperty<System.Single>)o).OnChangeWithOldVal;
        }

        static StackObject* CopyToStack_OnChangeWithOldVal_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((JEngine.Misc.BindableProperty<System.Single>)o).OnChangeWithOldVal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnChangeWithOldVal_0(ref object o, object v)
        {
            ((JEngine.Misc.BindableProperty<System.Single>)o).OnChangeWithOldVal = (System.Action<System.Single, System.Single>)v;
        }

        static StackObject* AssignFromStack_OnChangeWithOldVal_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.Single, System.Single> @OnChangeWithOldVal = (System.Action<System.Single, System.Single>)typeof(System.Action<System.Single, System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((JEngine.Misc.BindableProperty<System.Single>)o).OnChangeWithOldVal = @OnChangeWithOldVal;
            return ptr_of_this_method;
        }

        static object get_OnChange_1(ref object o)
        {
            return ((JEngine.Misc.BindableProperty<System.Single>)o).OnChange;
        }

        static StackObject* CopyToStack_OnChange_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((JEngine.Misc.BindableProperty<System.Single>)o).OnChange;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnChange_1(ref object o, object v)
        {
            ((JEngine.Misc.BindableProperty<System.Single>)o).OnChange = (System.Action<System.Single>)v;
        }

        static StackObject* AssignFromStack_OnChange_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.Single> @OnChange = (System.Action<System.Single>)typeof(System.Action<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((JEngine.Misc.BindableProperty<System.Single>)o).OnChange = @OnChange;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @val = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = new JEngine.Misc.BindableProperty<System.Single>(@val);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
