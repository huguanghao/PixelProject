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
    unsafe class YKGame_Runtime_NodeLink_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(YKGame.Runtime.NodeLink);

            field = type.GetField("previousPath", flag);
            app.RegisterCLRFieldGetter(field, get_previousPath_0);
            app.RegisterCLRFieldSetter(field, set_previousPath_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_previousPath_0, AssignFromStack_previousPath_0);
            field = type.GetField("nodeName", flag);
            app.RegisterCLRFieldGetter(field, get_nodeName_1);
            app.RegisterCLRFieldSetter(field, set_nodeName_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_nodeName_1, AssignFromStack_nodeName_1);
            field = type.GetField("nextPath", flag);
            app.RegisterCLRFieldGetter(field, get_nextPath_2);
            app.RegisterCLRFieldSetter(field, set_nextPath_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_nextPath_2, AssignFromStack_nextPath_2);


        }



        static object get_previousPath_0(ref object o)
        {
            return ((YKGame.Runtime.NodeLink)o).previousPath;
        }

        static StackObject* CopyToStack_previousPath_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((YKGame.Runtime.NodeLink)o).previousPath;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_previousPath_0(ref object o, object v)
        {
            ((YKGame.Runtime.NodeLink)o).previousPath = (System.Int32[])v;
        }

        static StackObject* AssignFromStack_previousPath_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32[] @previousPath = (System.Int32[])typeof(System.Int32[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((YKGame.Runtime.NodeLink)o).previousPath = @previousPath;
            return ptr_of_this_method;
        }

        static object get_nodeName_1(ref object o)
        {
            return ((YKGame.Runtime.NodeLink)o).nodeName;
        }

        static StackObject* CopyToStack_nodeName_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((YKGame.Runtime.NodeLink)o).nodeName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_nodeName_1(ref object o, object v)
        {
            ((YKGame.Runtime.NodeLink)o).nodeName = (System.String)v;
        }

        static StackObject* AssignFromStack_nodeName_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @nodeName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((YKGame.Runtime.NodeLink)o).nodeName = @nodeName;
            return ptr_of_this_method;
        }

        static object get_nextPath_2(ref object o)
        {
            return ((YKGame.Runtime.NodeLink)o).nextPath;
        }

        static StackObject* CopyToStack_nextPath_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((YKGame.Runtime.NodeLink)o).nextPath;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_nextPath_2(ref object o, object v)
        {
            ((YKGame.Runtime.NodeLink)o).nextPath = (System.Int32[])v;
        }

        static StackObject* AssignFromStack_nextPath_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32[] @nextPath = (System.Int32[])typeof(System.Int32[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((YKGame.Runtime.NodeLink)o).nextPath = @nextPath;
            return ptr_of_this_method;
        }



    }
}
