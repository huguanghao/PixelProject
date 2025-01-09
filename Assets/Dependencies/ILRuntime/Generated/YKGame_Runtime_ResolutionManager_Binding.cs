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
    unsafe class YKGame_Runtime_ResolutionManager_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(YKGame.Runtime.ResolutionManager);
            args = new Type[]{};
            method = type.GetMethod("get_CurrentResolutionIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CurrentResolutionIndex_0);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FullScreenMode)};
            method = type.GetMethod("SetResolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetResolution_1);

            field = type.GetField("instance", flag);
            app.RegisterCLRFieldGetter(field, get_instance_0);
            app.RegisterCLRFieldSetter(field, set_instance_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_instance_0, AssignFromStack_instance_0);
            field = type.GetField("resolutions", flag);
            app.RegisterCLRFieldGetter(field, get_resolutions_1);
            app.RegisterCLRFieldSetter(field, set_resolutions_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_resolutions_1, AssignFromStack_resolutions_1);


        }


        static StackObject* get_CurrentResolutionIndex_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            YKGame.Runtime.ResolutionManager instance_of_this_method = (YKGame.Runtime.ResolutionManager)typeof(YKGame.Runtime.ResolutionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CurrentResolutionIndex;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetResolution_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.FullScreenMode @fullScreen = (UnityEngine.FullScreenMode)typeof(UnityEngine.FullScreenMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @height = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @width = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            YKGame.Runtime.ResolutionManager instance_of_this_method = (YKGame.Runtime.ResolutionManager)typeof(YKGame.Runtime.ResolutionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetResolution(@width, @height, @fullScreen);

            return __ret;
        }


        static object get_instance_0(ref object o)
        {
            return YKGame.Runtime.ResolutionManager.instance;
        }

        static StackObject* CopyToStack_instance_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = YKGame.Runtime.ResolutionManager.instance;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_instance_0(ref object o, object v)
        {
            YKGame.Runtime.ResolutionManager.instance = (YKGame.Runtime.ResolutionManager)v;
        }

        static StackObject* AssignFromStack_instance_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            YKGame.Runtime.ResolutionManager @instance = (YKGame.Runtime.ResolutionManager)typeof(YKGame.Runtime.ResolutionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            YKGame.Runtime.ResolutionManager.instance = @instance;
            return ptr_of_this_method;
        }

        static object get_resolutions_1(ref object o)
        {
            return ((YKGame.Runtime.ResolutionManager)o).resolutions;
        }

        static StackObject* CopyToStack_resolutions_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((YKGame.Runtime.ResolutionManager)o).resolutions;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_resolutions_1(ref object o, object v)
        {
            ((YKGame.Runtime.ResolutionManager)o).resolutions = (System.Collections.Generic.List<UnityEngine.Resolution>)v;
        }

        static StackObject* AssignFromStack_resolutions_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.List<UnityEngine.Resolution> @resolutions = (System.Collections.Generic.List<UnityEngine.Resolution>)typeof(System.Collections.Generic.List<UnityEngine.Resolution>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((YKGame.Runtime.ResolutionManager)o).resolutions = @resolutions;
            return ptr_of_this_method;
        }



    }
}
