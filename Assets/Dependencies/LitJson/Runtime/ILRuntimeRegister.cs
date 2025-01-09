using System;
using LitJson;
using UnityEngine;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;

namespace JEngine.Core
{
    public class ILRuntimeRegister : IRegisterHelper
    {
        public void Register(AppDomain appdomain)
        {
            appdomain.DelegateManager.RegisterDelegateConvertor<Action<JsonData2>>(action =>
            {
                return new Action<JsonData2>(a => { ((Action<JsonData2>)action)(a); });
            });
            JsonMapper.RegisterILRuntimeCLRRedirection(appdomain);   
        }
    }
}