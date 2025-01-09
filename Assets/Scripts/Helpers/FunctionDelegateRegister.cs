using JEngine.Core;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;

namespace JEngine.Helper
{
    public class FunctionDelegateRegister : IRegisterHelper
    {
        public void Register(AppDomain appdomain)
        {
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.GameObject, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<global::MonoBehaviourAdapter.Adaptor, global::MonoBehaviourAdapter.Adaptor, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.ParticleSystem, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<FairyGUI.GButton, System.Single>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Int32, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.String, System.String, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.String>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<Spine.Slot, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Int32, System.String>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.ValueTuple<System.Int32, System.Int32, System.Int32>, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.LineRenderer, System.Single>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.String, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Object, System.Object>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Collider, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Single>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Double>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int64>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.String>();

            /*  这里注册你所需要的FunctionDelegate，参考报错的内容黏贴就好，举个例子：
             *
                appdomain.DelegateManager.RegisterFunctionDelegate<System.String, System.Boolean>();
             *
             */
        }
    }
}