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
    unsafe class YooAsset_YooAssets_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(YooAsset.YooAssets);
            args = new Type[]{typeof(System.Int64)};
            method = type.GetMethod("SetOperationSystemMaxTimeSlice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetOperationSystemMaxTimeSlice_0);
            args = new Type[]{};
            method = type.GetMethod("GetSandboxRoot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSandboxRoot_1);


        }


        static StackObject* SetOperationSystemMaxTimeSlice_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 @milliseconds = *(long*)&ptr_of_this_method->Value;


            YooAsset.YooAssets.SetOperationSystemMaxTimeSlice(@milliseconds);

            return __ret;
        }

        static StackObject* GetSandboxRoot_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = YooAsset.YooAssets.GetSandboxRoot();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}
