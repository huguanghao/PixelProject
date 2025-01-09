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
    unsafe class JEngine_Misc_BindableProperty_1_ILTypeInstance_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(JEngine.Misc.BindableProperty<ILRuntime.Runtime.Intepreter.ILTypeInstance>);
            args = new Type[]{};
            method = type.GetMethod("get_Value", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Value_0);

            field = type.GetField("OnChangeWithOldVal", flag);
            app.RegisterCLRFieldGetter(field, get_OnChangeWithOldVal_0);
            app.RegisterCLRFieldSetter(field, set_OnChangeWithOldVal_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnChangeWithOldVal_0, AssignFromStack_OnChangeWithOldVal_0);
            field = type.GetField("OnChange", flag);
            app.RegisterCLRFieldGetter(field, get_OnChange_1);
            app.RegisterCLRFieldSetter(field, set_OnChange_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnChange_1, AssignFromStack_OnChange_1);

            args = new Type[]{typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_Value_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            JEngine.Misc.BindableProperty<ILRuntime.Runtime.Intepreter.ILTypeInstance> instance_of_this_method = (JEngine.Misc.BindableProperty<ILRuntime.Runtime.Intepreter.ILTypeInstance>)typeof(JEngine.Misc.BindableProperty<ILRuntime.Runtime.Intepreter.ILTypeInstance>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Value;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_OnChangeWithOldVal_0(ref object o)
        {
            return ((JEngine.Misc.BindableProperty<ILRuntime.Runtime.Intepreter.ILTypeInstance>)o).OnChangeWithOldVal;
        }

        static StackObject* CopyToStack_OnChangeWithOldVal_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((JEngine.Misc.BindableProperty<ILRuntime.Runtime.Intepreter.ILTypeInstance>)o).OnChangeWithOldVal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnChangeWithOldVal_0(ref object o, object v)
        {
            ((JEngine.Misc.BindableProperty<ILRuntime.Runtime.Intepreter.ILTypeInstance>)o).OnChangeWithOldVal = (System.Action<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance>)v;
        }

        static StackObject* AssignFromStack_OnChangeWithOldVal_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance> @OnChangeWithOldVal = (System.Action<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance>)typeof(System.Action<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((JEngine.Misc.BindableProperty<ILRuntime.Runtime.Intepreter.ILTypeInstance>)o).OnChangeWithOldVal = @OnChangeWithOldVal;
            return ptr_of_this_method;
        }

        static object get_OnChange_1(ref object o)
        {
            return ((JEngine.Misc.BindableProperty<ILRuntime.Runtime.Intepreter.ILTypeInstance>)o).OnChange;
        }

        static StackObject* CopyToStack_OnChange_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((JEngine.Misc.BindableProperty<ILRuntime.Runtime.Intepreter.ILTypeInstance>)o).OnChange;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnChange_1(ref object o, object v)
        {
            ((JEngine.Misc.BindableProperty<ILRuntime.Runtime.Intepreter.ILTypeInstance>)o).OnChange = (System.Action<ILRuntime.Runtime.Intepreter.ILTypeInstance>)v;
        }

        static StackObject* AssignFromStack_OnChange_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<ILRuntime.Runtime.Intepreter.ILTypeInstance> @OnChange = (System.Action<ILRuntime.Runtime.Intepreter.ILTypeInstance>)typeof(System.Action<ILRuntime.Runtime.Intepreter.ILTypeInstance>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((JEngine.Misc.BindableProperty<ILRuntime.Runtime.Intepreter.ILTypeInstance>)o).OnChange = @OnChange;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ILRuntime.Runtime.Intepreter.ILTypeInstance @val = (ILRuntime.Runtime.Intepreter.ILTypeInstance)typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new JEngine.Misc.BindableProperty<ILRuntime.Runtime.Intepreter.ILTypeInstance>(@val);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
