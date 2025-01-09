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
    unsafe class MapSetting_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::MapSetting);
            args = new Type[]{};
            method = type.GetMethod("AutoSetStartPos", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AutoSetStartPos_0);
            args = new Type[]{typeof(UnityEngine.Vector2Int)};
            method = type.GetMethod("set_Size", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Size_1);
            args = new Type[]{};
            method = type.GetMethod("get_Size", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Size_2);

            field = type.GetField("StartWorldPosition", flag);
            app.RegisterCLRFieldGetter(field, get_StartWorldPosition_0);
            app.RegisterCLRFieldSetter(field, set_StartWorldPosition_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_StartWorldPosition_0, AssignFromStack_StartWorldPosition_0);


        }


        static StackObject* AutoSetStartPos_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::MapSetting instance_of_this_method = (global::MapSetting)typeof(global::MapSetting).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AutoSetStartPos();

            return __ret;
        }

        static StackObject* set_Size_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2Int @value = new UnityEngine.Vector2Int();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.ParseValue(ref @value, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @value = (UnityEngine.Vector2Int)typeof(UnityEngine.Vector2Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::MapSetting instance_of_this_method = (global::MapSetting)typeof(global::MapSetting).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Size = value;

            return __ret;
        }

        static StackObject* get_Size_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::MapSetting instance_of_this_method = (global::MapSetting)typeof(global::MapSetting).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Size;

            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector2Int_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }


        static object get_StartWorldPosition_0(ref object o)
        {
            return ((global::MapSetting)o).StartWorldPosition;
        }

        static StackObject* CopyToStack_StartWorldPosition_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::MapSetting)o).StartWorldPosition;
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static void set_StartWorldPosition_0(ref object o, object v)
        {
            ((global::MapSetting)o).StartWorldPosition = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_StartWorldPosition_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @StartWorldPosition = new UnityEngine.Vector3();
            if (ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                ILRuntime.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @StartWorldPosition, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @StartWorldPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            }
            ((global::MapSetting)o).StartWorldPosition = @StartWorldPosition;
            return ptr_of_this_method;
        }



    }
}
