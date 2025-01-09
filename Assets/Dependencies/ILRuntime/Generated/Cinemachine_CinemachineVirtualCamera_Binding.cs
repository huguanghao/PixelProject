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
    unsafe class Cinemachine_CinemachineVirtualCamera_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Cinemachine.CinemachineVirtualCamera);
            Dictionary<string, List<MethodInfo>> genericMethods = new Dictionary<string, List<MethodInfo>>();
            List<MethodInfo> lst = null;                    
            foreach(var m in type.GetMethods())
            {
                if(m.IsGenericMethodDefinition)
                {
                    if (!genericMethods.TryGetValue(m.Name, out lst))
                    {
                        lst = new List<MethodInfo>();
                        genericMethods[m.Name] = lst;
                    }
                    lst.Add(m);
                }
            }
            args = new Type[]{typeof(Cinemachine.CinemachineFramingTransposer)};
            if (genericMethods.TryGetValue("GetCinemachineComponent", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(Cinemachine.CinemachineFramingTransposer)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, GetCinemachineComponent_0);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(Cinemachine.CinemachineCore.Stage)};
            method = type.GetMethod("GetCinemachineComponent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCinemachineComponent_1);

            field = type.GetField("m_Lens", flag);
            app.RegisterCLRFieldGetter(field, get_m_Lens_0);
            app.RegisterCLRFieldSetter(field, set_m_Lens_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_Lens_0, AssignFromStack_m_Lens_0);


        }


        static StackObject* GetCinemachineComponent_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Cinemachine.CinemachineVirtualCamera instance_of_this_method = (Cinemachine.CinemachineVirtualCamera)typeof(Cinemachine.CinemachineVirtualCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCinemachineComponent<Cinemachine.CinemachineFramingTransposer>();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetCinemachineComponent_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Cinemachine.CinemachineCore.Stage @stage = (Cinemachine.CinemachineCore.Stage)typeof(Cinemachine.CinemachineCore.Stage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Cinemachine.CinemachineVirtualCamera instance_of_this_method = (Cinemachine.CinemachineVirtualCamera)typeof(Cinemachine.CinemachineVirtualCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCinemachineComponent(@stage);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_m_Lens_0(ref object o)
        {
            return ((Cinemachine.CinemachineVirtualCamera)o).m_Lens;
        }

        static StackObject* CopyToStack_m_Lens_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Cinemachine.CinemachineVirtualCamera)o).m_Lens;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_Lens_0(ref object o, object v)
        {
            ((Cinemachine.CinemachineVirtualCamera)o).m_Lens = (Cinemachine.LensSettings)v;
        }

        static StackObject* AssignFromStack_m_Lens_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Cinemachine.LensSettings @m_Lens = (Cinemachine.LensSettings)typeof(Cinemachine.LensSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Cinemachine.CinemachineVirtualCamera)o).m_Lens = @m_Lens;
            return ptr_of_this_method;
        }



    }
}
