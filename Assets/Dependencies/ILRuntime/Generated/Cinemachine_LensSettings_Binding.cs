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
    unsafe class Cinemachine_LensSettings_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Cinemachine.LensSettings);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_Orthographic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Orthographic_0);

            field = type.GetField("OrthographicSize", flag);
            app.RegisterCLRFieldGetter(field, get_OrthographicSize_0);
            app.RegisterCLRFieldSetter(field, set_OrthographicSize_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OrthographicSize_0, AssignFromStack_OrthographicSize_0);
            field = type.GetField("FieldOfView", flag);
            app.RegisterCLRFieldGetter(field, get_FieldOfView_1);
            app.RegisterCLRFieldSetter(field, set_FieldOfView_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_FieldOfView_1, AssignFromStack_FieldOfView_1);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new Cinemachine.LensSettings());


        }

        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Cinemachine.LensSettings instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Cinemachine.LensSettings[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* set_Orthographic_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Cinemachine.LensSettings instance_of_this_method = (Cinemachine.LensSettings)typeof(Cinemachine.LensSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            instance_of_this_method.Orthographic = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }


        static object get_OrthographicSize_0(ref object o)
        {
            return ((Cinemachine.LensSettings)o).OrthographicSize;
        }

        static StackObject* CopyToStack_OrthographicSize_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Cinemachine.LensSettings)o).OrthographicSize;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_OrthographicSize_0(ref object o, object v)
        {
            Cinemachine.LensSettings ins =(Cinemachine.LensSettings)o;
            ins.OrthographicSize = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_OrthographicSize_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @OrthographicSize = *(float*)&ptr_of_this_method->Value;
            Cinemachine.LensSettings ins =(Cinemachine.LensSettings)o;
            ins.OrthographicSize = @OrthographicSize;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_FieldOfView_1(ref object o)
        {
            return ((Cinemachine.LensSettings)o).FieldOfView;
        }

        static StackObject* CopyToStack_FieldOfView_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Cinemachine.LensSettings)o).FieldOfView;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_FieldOfView_1(ref object o, object v)
        {
            Cinemachine.LensSettings ins =(Cinemachine.LensSettings)o;
            ins.FieldOfView = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_FieldOfView_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @FieldOfView = *(float*)&ptr_of_this_method->Value;
            Cinemachine.LensSettings ins =(Cinemachine.LensSettings)o;
            ins.FieldOfView = @FieldOfView;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Cinemachine.LensSettings();
            ins = (Cinemachine.LensSettings)o;
            return ins;
        }


    }
}
