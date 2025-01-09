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
    unsafe class System_ValueTuple_2_Vector3_Array_Array_NodeLink_Array_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]>);

            field = type.GetField("Item1", flag);
            app.RegisterCLRFieldGetter(field, get_Item1_0);
            app.RegisterCLRFieldSetter(field, set_Item1_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Item1_0, AssignFromStack_Item1_0);
            field = type.GetField("Item2", flag);
            app.RegisterCLRFieldGetter(field, get_Item2_1);
            app.RegisterCLRFieldSetter(field, set_Item2_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Item2_1, AssignFromStack_Item2_1);

            app.RegisterCLRCreateDefaultInstance(type, () => new System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]>());


        }

        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]> instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]>[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Item1_0(ref object o)
        {
            return ((System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]>)o).Item1;
        }

        static StackObject* CopyToStack_Item1_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]>)o).Item1;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Item1_0(ref object o, object v)
        {
            System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]> ins =(System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]>)o;
            ins.Item1 = (UnityEngine.Vector3[][])v;
            o = ins;
        }

        static StackObject* AssignFromStack_Item1_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3[][] @Item1 = (UnityEngine.Vector3[][])typeof(UnityEngine.Vector3[][]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]> ins =(System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]>)o;
            ins.Item1 = @Item1;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Item2_1(ref object o)
        {
            return ((System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]>)o).Item2;
        }

        static StackObject* CopyToStack_Item2_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]>)o).Item2;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Item2_1(ref object o, object v)
        {
            System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]> ins =(System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]>)o;
            ins.Item2 = (YKGame.Runtime.NodeLink[])v;
            o = ins;
        }

        static StackObject* AssignFromStack_Item2_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            YKGame.Runtime.NodeLink[] @Item2 = (YKGame.Runtime.NodeLink[])typeof(YKGame.Runtime.NodeLink[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]> ins =(System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]>)o;
            ins.Item2 = @Item2;
            o = ins;
            return ptr_of_this_method;
        }



    }
}
