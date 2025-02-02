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
    unsafe class FairyGUI_PackageItem_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.PackageItem);

            field = type.GetField("name", flag);
            app.RegisterCLRFieldGetter(field, get_name_0);
            app.RegisterCLRFieldSetter(field, set_name_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_name_0, AssignFromStack_name_0);
            field = type.GetField("branches", flag);
            app.RegisterCLRFieldGetter(field, get_branches_1);
            app.RegisterCLRFieldSetter(field, set_branches_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_branches_1, AssignFromStack_branches_1);


        }



        static object get_name_0(ref object o)
        {
            return ((FairyGUI.PackageItem)o).name;
        }

        static StackObject* CopyToStack_name_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((FairyGUI.PackageItem)o).name;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_name_0(ref object o, object v)
        {
            ((FairyGUI.PackageItem)o).name = (System.String)v;
        }

        static StackObject* AssignFromStack_name_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((FairyGUI.PackageItem)o).name = @name;
            return ptr_of_this_method;
        }

        static object get_branches_1(ref object o)
        {
            return ((FairyGUI.PackageItem)o).branches;
        }

        static StackObject* CopyToStack_branches_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((FairyGUI.PackageItem)o).branches;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_branches_1(ref object o, object v)
        {
            ((FairyGUI.PackageItem)o).branches = (System.String[])v;
        }

        static StackObject* AssignFromStack_branches_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String[] @branches = (System.String[])typeof(System.String[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((FairyGUI.PackageItem)o).branches = @branches;
            return ptr_of_this_method;
        }



    }
}
