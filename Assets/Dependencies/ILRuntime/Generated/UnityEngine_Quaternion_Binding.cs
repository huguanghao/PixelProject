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
    unsafe class UnityEngine_Quaternion_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Quaternion);
            args = new Type[]{typeof(System.Single), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("AngleAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AngleAxis_0);
            args = new Type[]{typeof(UnityEngine.Quaternion), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("op_Multiply", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, op_Multiply_1);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("LookRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LookRotation_2);
            args = new Type[]{};
            method = type.GetMethod("get_identity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_identity_3);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("LookRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LookRotation_4);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("Euler", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Euler_5);
            args = new Type[]{typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single)};
            method = type.GetMethod("Slerp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Slerp_6);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Quaternion());

            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }

        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.Quaternion instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Quaternion[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* AngleAxis_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @axis = new UnityEngine.Vector3();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @axis, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @axis = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @angle = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Quaternion.AngleAxis(@angle, @axis);

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* op_Multiply_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @point = new UnityEngine.Vector3();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @point, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @point = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Quaternion @rotation = new UnityEngine.Quaternion();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder.ParseValue(ref @rotation, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }


            var result_of_this_method = rotation * point;

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* LookRotation_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @forward = new UnityEngine.Vector3();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @forward, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @forward = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }


            var result_of_this_method = UnityEngine.Quaternion.LookRotation(@forward);

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* get_identity_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Quaternion.identity;

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* LookRotation_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @upwards = new UnityEngine.Vector3();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @upwards, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @upwards = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @forward = new UnityEngine.Vector3();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @forward, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @forward = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }


            var result_of_this_method = UnityEngine.Quaternion.LookRotation(@forward, @upwards);

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* Euler_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @euler = new UnityEngine.Vector3();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @euler, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @euler = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }


            var result_of_this_method = UnityEngine.Quaternion.Euler(@euler);

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* Slerp_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @t = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Quaternion @b = new UnityEngine.Quaternion();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder.ParseValue(ref @b, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @b = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Quaternion @a = new UnityEngine.Quaternion();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder.ParseValue(ref @a, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @a = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }


            var result_of_this_method = UnityEngine.Quaternion.Slerp(@a, @b, @t);

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @w = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @z = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @y = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = new UnityEngine.Quaternion(@x, @y, @z, @w);

            if(!isNewObj)
            {
                __ret--;
                if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder != null) {
                    ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder.WriteBackValue(__domain, __ret, __mStack, ref result_of_this_method);
                } else {
                    WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                }
                return __ret;
            }

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Quaternion_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
                return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }


    }
}
