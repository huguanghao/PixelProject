using JEngine.Core;
using System;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;

namespace JEngine.Helper
{
    public class DelegateConvertorRegister: IRegisterHelper
    {
        public void Register(AppDomain appdomain)
        {
            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.GameObject>>((act) =>
            {
                return new System.Predicate<UnityEngine.GameObject>((obj) =>
                {
                    return ((Func<UnityEngine.GameObject, System.Boolean>)act)(obj);
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<DG.Tweening.Core.DOGetter<System.Single>>((act) =>
            {
                return new DG.Tweening.Core.DOGetter<System.Single>(() =>
                {
                    return ((Func<System.Single>)act)();
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<DG.Tweening.Core.DOSetter<System.Single>>((act) =>
            {
                return new DG.Tweening.Core.DOSetter<System.Single>((pNewValue) =>
                {
                    ((Action<System.Single>)act)(pNewValue);
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<DG.Tweening.TweenCallback>((act) =>
            {
                return new DG.Tweening.TweenCallback(() =>
                {
                    ((Action)act)();
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<ILRuntime.Runtime.Intepreter.ILTypeInstance>>((act) =>
            {
                return new System.Comparison<ILRuntime.Runtime.Intepreter.ILTypeInstance>((x, y) =>
                {
                    return ((Func<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)act)(x, y);
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<FairyGUI.ListItemRenderer>((act) =>
            {
                return new FairyGUI.ListItemRenderer((index, item) =>
                {
                    ((Action<System.Int32, FairyGUI.GObject>)act)(index, item);
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<global::MonoBehaviourAdapter.Adaptor>>((act) =>
            {
                return new System.Comparison<global::MonoBehaviourAdapter.Adaptor>((x, y) =>
                {
                    return ((Func<global::MonoBehaviourAdapter.Adaptor, global::MonoBehaviourAdapter.Adaptor, System.Int32>)act)(x, y);
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.ParticleSystem>>((act) =>
            {
                return new System.Predicate<UnityEngine.ParticleSystem>((obj) =>
                {
                    return ((System.Func<UnityEngine.ParticleSystem, System.Boolean>)act)(obj);
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<FairyGUI.PlayCompleteCallback>((act) =>
            {
                return new FairyGUI.PlayCompleteCallback(() =>
                {
                    ((System.Action)act)();
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<FairyGUI.GTweenCallback1>((act) =>
            {
                return new FairyGUI.GTweenCallback1((tweener) =>
                {
                    ((System.Action<FairyGUI.GTweener>)act)(tweener);
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Int32>>((act) =>
            {
                return new System.Predicate<System.Int32>((obj) =>
                {
                    return ((System.Func<System.Int32, System.Boolean>)act)(obj);
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.String>>((act) =>
            {
                return new System.Comparison<System.String>((x, y) =>
                {
                    return ((System.Func<System.String, System.String, System.Int32>)act)(x, y);
                });
            }); 
            appdomain.DelegateManager.RegisterDelegateConvertor<FairyGUI.EventCallback1>((act) =>
            {
                return new FairyGUI.EventCallback1((context) =>
                {
                    ((System.Action<FairyGUI.EventContext>)act)(context);
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<FairyGUI.EventCallback0>((act) =>
            {
                return new FairyGUI.EventCallback0(() =>
                {
                    ((System.Action)act)();
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<Spine.Slot>>((act) =>
            {
                return new System.Predicate<Spine.Slot>((obj) =>
                {
                    return ((Func<Spine.Slot, System.Boolean>)act)(obj);
                });
            }); 
            appdomain.DelegateManager.RegisterDelegateConvertor<FairyGUI.TransitionHook>((act) =>
            {
                return new FairyGUI.TransitionHook(() =>
                {
                    ((Action)act)();
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<Spine.AnimationState.TrackEntryDelegate>((act) =>
            {
                return new Spine.AnimationState.TrackEntryDelegate((trackEntry) =>
                {
                    ((Action<Spine.TrackEntry>)act)(trackEntry);
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<FairyGUI.GTweenCallback>((act) =>
            {
                return new FairyGUI.GTweenCallback(() =>
                {
                    ((Action)act)();
                });
            }); 
            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Cinemachine.ICinemachineCamera, Cinemachine.ICinemachineCamera>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<Cinemachine.ICinemachineCamera, Cinemachine.ICinemachineCamera>((arg0, arg1) =>
                {
                    ((Action<Cinemachine.ICinemachineCamera, Cinemachine.ICinemachineCamera>)act)(arg0, arg1);
                });
            }); 
            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Cinemachine.CinemachineBrain>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<Cinemachine.CinemachineBrain>((arg0) =>
                {
                    ((Action<Cinemachine.CinemachineBrain>)act)(arg0);
                });
            }); 
            appdomain.DelegateManager.RegisterDelegateConvertor<FairyGUI.GObjectPool.InitCallbackDelegate>((act) =>
            {
                return new FairyGUI.GObjectPool.InitCallbackDelegate((obj) =>
                {
                    ((Action<FairyGUI.GObject>)act)(obj);
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>((arg0) =>
                {
                    ((Action<UnityEngine.SceneManagement.Scene>)act)(arg0);
                });
            });


            /*  这里注册你所需要的DelegateConvertor，参考报错的内容黏贴就好，举个例子：
             *
                appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.String>>(act =>
                {
                    return new System.Predicate<System.String>(obj =>
                    {
                        return ((System.Func<System.String, System.Boolean>)act)(obj);
                    });
                });
             *
             */
        }
    }
}