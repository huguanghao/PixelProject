using JEngine.Core;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;

namespace JEngine.Helper
{
    public class MethodDelegateRegister : IRegisterHelper
    {
        public void Register(AppDomain appdomain)
        {
            /*  这里注册你所需要的MethodDelegate，参考报错的内容黏贴就好，举个例子：
             *
                appdomain.DelegateManager.RegisterMethodDelegate<object>();
             *
             */
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.AsyncOperation>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Int32, FairyGUI.GObject>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.String, System.Object>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.InputSystem.InputAction.CallbackContext>();
            appdomain.DelegateManager.RegisterMethodDelegate<FairyGUI.GTweener>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Collections.Generic.List<ILRuntime.Runtime.Intepreter.ILTypeInstance>>();
            appdomain.DelegateManager.RegisterMethodDelegate<FairyGUI.EventContext>();
            appdomain.DelegateManager.RegisterMethodDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance>();
            appdomain.DelegateManager.RegisterMethodDelegate<Spine.TrackEntry>();
            appdomain.DelegateManager.RegisterMethodDelegate<Cinemachine.ICinemachineCamera, Cinemachine.ICinemachineCamera>(); 
            appdomain.DelegateManager.RegisterMethodDelegate<Cinemachine.CinemachineBrain>(); 
            appdomain.DelegateManager.RegisterMethodDelegate<YooAsset.AsyncOperationBase>();
            appdomain.DelegateManager.RegisterMethodDelegate<FairyGUI.GObject>();
            appdomain.DelegateManager.RegisterMethodDelegate<FairyGUI.UpdateContext>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.SceneManagement.Scene>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Playables.PlayableDirector>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Collider>();

        }
    }
}