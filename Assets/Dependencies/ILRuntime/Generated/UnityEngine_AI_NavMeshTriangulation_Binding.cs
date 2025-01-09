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
    unsafe class UnityEngine_AI_NavMeshTriangulation_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.AI.NavMeshTriangulation);

            field = type.GetField("indices", flag);
            app.RegisterCLRFieldGetter(field, get_indices_0);
            app.RegisterCLRFieldSetter(field, set_indices_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_indices_0, AssignFromStack_indices_0);
            field = type.GetField("vertices", flag);
            app.RegisterCLRFieldGetter(field, get_vertices_1);
            app.RegisterCLRFieldSetter(field, set_vertices_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_vertices_1, AssignFromStack_vertices_1);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AI.NavMeshTriangulation());


        }

        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.AI.NavMeshTriangulation instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.AI.NavMeshTriangulation[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_indices_0(ref object o)
        {
            return ((UnityEngine.AI.NavMeshTriangulation)o).indices;
        }

        static StackObject* CopyToStack_indices_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.AI.NavMeshTriangulation)o).indices;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_indices_0(ref object o, object v)
        {
            UnityEngine.AI.NavMeshTriangulation ins =(UnityEngine.AI.NavMeshTriangulation)o;
            ins.indices = (System.Int32[])v;
            o = ins;
        }

        static StackObject* AssignFromStack_indices_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32[] @indices = (System.Int32[])typeof(System.Int32[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            UnityEngine.AI.NavMeshTriangulation ins =(UnityEngine.AI.NavMeshTriangulation)o;
            ins.indices = @indices;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_vertices_1(ref object o)
        {
            return ((UnityEngine.AI.NavMeshTriangulation)o).vertices;
        }

        static StackObject* CopyToStack_vertices_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.AI.NavMeshTriangulation)o).vertices;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_vertices_1(ref object o, object v)
        {
            UnityEngine.AI.NavMeshTriangulation ins =(UnityEngine.AI.NavMeshTriangulation)o;
            ins.vertices = (UnityEngine.Vector3[])v;
            o = ins;
        }

        static StackObject* AssignFromStack_vertices_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3[] @vertices = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            UnityEngine.AI.NavMeshTriangulation ins =(UnityEngine.AI.NavMeshTriangulation)o;
            ins.vertices = @vertices;
            o = ins;
            return ptr_of_this_method;
        }



    }
}
