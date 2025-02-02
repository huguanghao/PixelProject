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
    unsafe class LitJson_JsonMapper_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(LitJson.JsonMapper);
            MethodInfo[] methods = type.GetMethods(flag).Where(t => !t.IsGenericMethod).ToArray();
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("ToJson", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToJson_0);
            args = new Type[]{typeof(System.String)};
            method = methods.Where(t => t.Name.Equals("ToObject") && t.CheckMethodParams(args)).Single();
            app.RegisterCLRMethodRedirection(method, ToObject_1);
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
            args = new Type[]{typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance)};
            if (genericMethods.TryGetValue("ToObject", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, ToObject_2);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(System.Collections.Generic.Dictionary<System.String, System.String>)};
            if (genericMethods.TryGetValue("ToObject", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(System.Collections.Generic.Dictionary<System.String, System.String>), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, ToObject_3);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<ILRuntime.Runtime.Intepreter.ILTypeInstance>>)};
            if (genericMethods.TryGetValue("ToObject", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<ILRuntime.Runtime.Intepreter.ILTypeInstance>>), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, ToObject_4);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(System.Collections.Generic.List<ILRuntime.Runtime.Intepreter.ILTypeInstance>)};
            if (genericMethods.TryGetValue("ToObject", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(System.Collections.Generic.List<ILRuntime.Runtime.Intepreter.ILTypeInstance>), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, ToObject_5);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(System.Collections.Generic.Dictionary<System.Int32, ILRuntime.Runtime.Intepreter.ILTypeInstance>)};
            if (genericMethods.TryGetValue("ToObject", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(System.Collections.Generic.Dictionary<System.Int32, ILRuntime.Runtime.Intepreter.ILTypeInstance>), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, ToObject_6);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(System.Collections.Generic.Dictionary<System.String, System.Int32>)};
            if (genericMethods.TryGetValue("ToObject", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(System.Collections.Generic.Dictionary<System.String, System.Int32>), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, ToObject_7);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(System.Collections.Generic.Dictionary<System.String, ILRuntime.Runtime.Intepreter.ILTypeInstance>)};
            if (genericMethods.TryGetValue("ToObject", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(System.Collections.Generic.Dictionary<System.String, ILRuntime.Runtime.Intepreter.ILTypeInstance>), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, ToObject_8);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(System.Collections.Generic.List<System.Int32>)};
            if (genericMethods.TryGetValue("ToObject", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(System.Collections.Generic.List<System.Int32>), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, ToObject_9);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance[])};
            if (genericMethods.TryGetValue("ToObject", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance[]), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, ToObject_10);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]>)};
            if (genericMethods.TryGetValue("ToObject", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]>), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, ToObject_11);

                        break;
                    }
                }
            }


        }


        static StackObject* ToJson_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @obj = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LitJson.JsonMapper.ToJson(@obj);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToObject_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @json = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LitJson.JsonMapper.ToObject(@json);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToObject_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @json = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LitJson.JsonMapper.ToObject<ILRuntime.Runtime.Intepreter.ILTypeInstance>(@json);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToObject_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @json = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LitJson.JsonMapper.ToObject<System.Collections.Generic.Dictionary<System.String, System.String>>(@json);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToObject_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @json = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LitJson.JsonMapper.ToObject<System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<ILRuntime.Runtime.Intepreter.ILTypeInstance>>>(@json);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToObject_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @json = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LitJson.JsonMapper.ToObject<System.Collections.Generic.List<ILRuntime.Runtime.Intepreter.ILTypeInstance>>(@json);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToObject_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @json = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LitJson.JsonMapper.ToObject<System.Collections.Generic.Dictionary<System.Int32, ILRuntime.Runtime.Intepreter.ILTypeInstance>>(@json);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToObject_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @json = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LitJson.JsonMapper.ToObject<System.Collections.Generic.Dictionary<System.String, System.Int32>>(@json);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToObject_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @json = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LitJson.JsonMapper.ToObject<System.Collections.Generic.Dictionary<System.String, ILRuntime.Runtime.Intepreter.ILTypeInstance>>(@json);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToObject_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @json = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LitJson.JsonMapper.ToObject<System.Collections.Generic.List<System.Int32>>(@json);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToObject_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @json = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LitJson.JsonMapper.ToObject<ILRuntime.Runtime.Intepreter.ILTypeInstance[]>(@json);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToObject_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @json = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LitJson.JsonMapper.ToObject<System.ValueTuple<UnityEngine.Vector3[][], YKGame.Runtime.NodeLink[]>>(@json);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}
