using System;
using System.Collections;
using System.Collections.Generic;
using FairyGUI;
using JEngine.Core;
using Spine.Unity;
using UnityEngine;
using YKGameFramework;

namespace YKGame.Runtime
{
    public class LoadingUI : MonoBehaviour, IUpdater
    {
        private GTextField tilte;
        private GTextField tilteex;
        private GProgressBar loadProgress;
        private static LoadingUI _instance = null;
        public string sceneName;

        public UIAssets m_Assets = null;
        public GObject MainWin { get; private set; }
        public static LoadingUI Instance
        {
            get
            {
                return _instance;
            }
        }

        private void OnOpenUIFormSuccess()
        {
            //当进入登陆界面时才关掉loading
        }

        public GLoader image;
        Controller controller = null;
        Controller Boxcontroller = null;
        GTextField boxTilte = null;
        GButton YesBtn = null;
        GButton NOBtn = null;
        GButton OKBtn = null;
        GTextField verLable = null;
        GTextField speedLable = null;
        public bool IsShowSpeed = false;
        public string speedtxt = "";
        void Awake()
        {
            //切换多语言分支
            UIPackage.branch = PlayerPrefs.GetString(Utility.PlayerPrefs.LANGUAGE, "cs");

            m_Assets = GetComponent<UIAssets>();
            MainWin = m_Assets.Package.CreateObject("Main");
            MainWin.visible = true;
            GRoot.inst.AddChild(MainWin);

            controller = MainWin.asCom.GetChild("n10").asCom.GetController("c1");
            controller.selectedIndex = 0;
            Boxcontroller = MainWin.asCom.GetChild("n10").asCom.GetChild("n10").asCom.GetController("c1");
            boxTilte = MainWin.asCom.GetChild("n10").asCom.GetChild("n10").asCom.GetChild("n17").asTextField;
            YesBtn = MainWin.asCom.GetChild("n10").asCom.GetChild("n10").asCom.GetChild("n16").asButton;
            YesBtn.title = Localzation.GetLocalString("yes");
            NOBtn = MainWin.asCom.GetChild("n10").asCom.GetChild("n10").asCom.GetChild("n15").asButton;
            NOBtn.title = Localzation.GetLocalString("no");
            OKBtn = MainWin.asCom.GetChild("n10").asCom.GetChild("n10").asCom.GetChild("n18").asButton;
            OKBtn.title = Localzation.GetLocalString("ok");
            GLabel title = MainWin.asCom.GetChild("n10").asCom.GetChild("n10").asCom.GetChild("n13").asLabel;
            title.title = Localzation.GetLocalString("tip");
            verLable = MainWin.asCom.GetChild("n10").asCom.GetChild("n32_Ver").asTextField;
            verLable.text = "";
            speedLable = MainWin.asCom.GetChild("n10").asCom.GetChild("n33_Download").asTextField;
            speedLable.text = "";
            tilte = MainWin.asCom.GetChild("n10").asCom.GetChild("n6").asTextField;
            tilte.text = "";
            tilteex = MainWin.asCom.GetChild("n10").asCom.GetChild("n7").asTextField;
            tilteex.text = "";
            tilteex.visible = false;
            loadProgress = MainWin.asCom.GetChild("n10").asCom.GetChild("n9").asProgress;
            image = MainWin.asCom.GetChild("n10").asCom.GetChild("n5").asLoader;
            image.texture = new NTexture(Resources.Load<Texture>("UI/background1"));

            MainWin.MakeFullScreen();
            MainWin.AddRelation(GRoot.inst, RelationType.Size);

            loadProgress.value = 0.0;
            IsShowSpeed = false;

            this.tilte.text = "";
            _instance = this;
        }

        void OnDestroy()
        {
            _instance = null;
            GRoot.inst.onSizeChanged.Remove(MainWin.MakeFullScreen);
            MainWin.Dispose();
        }

        public void YesNOBox(string title, Action<bool> callback)
        {
            boxTilte.text = title;
            controller.selectedIndex = 1;
            Boxcontroller.selectedIndex = 0;

            YesBtn.onClick.Set(
                () =>
                {
                    controller.selectedIndex = 0;
                    callback(true);
                }
            );

            NOBtn.onClick.Set(
               () =>
               {
                   controller.selectedIndex = 0;
                   callback(false);
               }
           );
        }

        public void OKBox(string title, Action callback)
        {

            controller.selectedIndex = 1;
            Boxcontroller.selectedIndex = 1;
            OKBtn.onClick.Set(
               () =>
               {
                   controller.selectedIndex = 0;
                   callback();
               }
           );
        }

        public void OnMessage(string msg)
        {
            tilte.text = msg;
        }

        public void OnProgress(float progress)
        {
            loadProgress.value = progress * loadProgress.max;
        }

        public void OnVersion(string ver)
        {
            verLable.text = string.Format(Localzation.GetLocalString("Ver"), Application.version, ver);
        }

        /*public void OnLoadSceneProgress(float progress)
        {
            loadProgress.value = progress * loadProgress.max;
        }

        public void OnLoadSceneFinish()
        {
            InitJEngine.Instance.LoadHotUpdateCallback();
        }

        public void OnUpdateFailed()
        {

        }*/
		
		public async void OnUpdateFinish(bool result)
        {
            if (result)
            {
                await AssetMgr.LoadSceneAsync(sceneName);
                Debug.Log("成功进入热更场景");
                await InitJEngine.Instance.LoadHotUpdateCallback();
            }
        }

    }

}
