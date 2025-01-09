using FairyGUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using YKGameFramework;

namespace YKGame.Runtime
{
    public class ResolutionManager : MonoBehaviour
    {
        public static ResolutionManager instance;

        public int designResolutionX = 1920;
        public int designResolutionY = 1080;
#if UNITY_ANDROID || UNITY_IOS
        private float deviceAspect = 0f;
#endif
        public List<Resolution> resolutions = new List<Resolution>();

        public Resolution CurrentResolution => resolutions[CurrentResolutionIndex];

        public int CurrentResolutionIndex
        {
            get
            {
                Resolution resolution = default;
                resolution.width = PlayerPrefs.GetInt(Utility.PlayerPrefs.ResolutionWidth);
                resolution.height = PlayerPrefs.GetInt(Utility.PlayerPrefs.ResolutionHeight);
                return Mathf.Clamp(resolutions.IndexOf(resolution), 0, resolutions.Count);
            }
        }

        private void Awake()
        {
            instance = this;
            StageCamera.CheckMainCamera();
            StageCamera.main.gameObject.SetActive(false);
            GRoot.inst.SetContentScaleFactor(designResolutionX, designResolutionY, UIContentScaler.ScreenMatchMode.MatchWidthOrHeight);
            StageCamera.main.gameObject.SetActive(true);

#if UNITY_ANDROID || UNITY_IOS
            float designRatio = (float)designResolutionX / designResolutionY;
            try
            {
                deviceAspect = (float)Screen.width / Screen.height;
            }
            catch
            {
                deviceAspect = designRatio;
            }
            Resolution resolution = default;
            resolution.width = Screen.width; 
            resolution.height = Screen.height;
            if (resolution.width >= resolution.height * designRatio)
                resolution.width = Mathf.CeilToInt(resolution.height * designRatio);
            else
                resolution.height = Mathf.CeilToInt(resolution.width / designRatio);
            resolutions.Add(resolution);
#else
            resolutions.AddRange(Screen.resolutions.Reverse().Select(item => { item.refreshRate = 0; return item; }).Distinct());
#endif
            //默认分辨率
            if (!PlayerPrefs.HasKey(Utility.PlayerPrefs.ResolutionWidth))
            {
                PlayerPrefs.SetInt(Utility.PlayerPrefs.ResolutionWidth, resolutions[0].width);
                PlayerPrefs.SetInt(Utility.PlayerPrefs.ResolutionHeight, resolutions[0].height);
                PlayerPrefs.SetInt(Utility.PlayerPrefs.ResolutionType, (int)Screen.fullScreenMode);
            }
            int width = PlayerPrefs.GetInt(Utility.PlayerPrefs.ResolutionWidth);
            int height = PlayerPrefs.GetInt(Utility.PlayerPrefs.ResolutionHeight);
            FullScreenMode mode = (FullScreenMode)PlayerPrefs.GetInt(Utility.PlayerPrefs.ResolutionType);
            SetResolution(width, height, mode);
        }

#if UNITY_EDITOR
        private void SetGameViewSize(int width, int height, bool fullScreen)
        {
            System.Type t_GameViewSizes = System.Reflection.Assembly.Load("UnityEditor").GetType("UnityEditor.GameViewSizes");
            System.Type t_GameViewSizeGroup = System.Reflection.Assembly.Load("UnityEditor").GetType("UnityEditor.GameViewSizeGroup");
            var gameViewSizes = t_GameViewSizes.BaseType.GetProperty("instance").GetValue(null);
            var gameViewSizeGroup = t_GameViewSizes.GetProperty("currentGroup").GetValue(gameViewSizes);
            IEnumerable list = (IEnumerable)t_GameViewSizeGroup.GetField("m_Custom", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(gameViewSizeGroup);
            int selectedIndex = -1;
            int i = 0;
            Type t_GameViewSize = Assembly.Load("UnityEditor").GetType("UnityEditor.GameViewSize");
            PropertyInfo _sizeType = t_GameViewSize.GetProperty("sizeType");
            PropertyInfo _width = t_GameViewSize.GetProperty("width");
            PropertyInfo _height = t_GameViewSize.GetProperty("height");
            foreach (var item in list)
            {
                int enumValue = (int)_sizeType.GetValue(item);
                if (enumValue == 1)
                {
                    int w = (int)_width.GetValue(item);
                    int h = (int)_height.GetValue(item);
                    if (w == width && h == height)
                    {
                        selectedIndex = i;
                        break;
                    }
                }
                i++;
            }
            if (selectedIndex == -1)
            {
                var t_GameViewSizeType = Assembly.Load("UnityEditor").GetType("UnityEditor.GameViewSizeType");
                var newSize = Activator.CreateInstance(t_GameViewSize, new object[] { Enum.Parse(t_GameViewSizeType, "FixedResolution"), width, height, "" });
                t_GameViewSizeGroup.GetMethod("AddCustomSize", new Type[] { t_GameViewSize }).Invoke(gameViewSizeGroup, new object[] { newSize });
                selectedIndex = i;
            }
            var buildInSize = t_GameViewSizeGroup.GetField("m_Builtin", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(gameViewSizeGroup);
            selectedIndex += (int)buildInSize.GetType().GetProperty("Count").GetValue(buildInSize);

            System.Type t_GameView = System.Reflection.Assembly.Load("UnityEditor").GetType("UnityEditor.GameView");
            EditorWindow window = EditorWindow.GetWindow(t_GameView, false, "GameView", false);
            t_GameView.GetMethod("SizeSelectionCallback").Invoke(window, new object[] { selectedIndex, null });
            window.maximized = fullScreen;
        }
#endif

        public void SetResolution(int width, int height, FullScreenMode fullScreen)
        {
            //保存设置
            PlayerPrefs.SetInt(Utility.PlayerPrefs.ResolutionWidth, width);
            PlayerPrefs.SetInt(Utility.PlayerPrefs.ResolutionHeight, height);
            PlayerPrefs.SetInt(Utility.PlayerPrefs.ResolutionType, (int)fullScreen);
#if UNITY_ANDROID || UNITY_IOS
            float aspect = (float)width / height;
            if (deviceAspect > aspect)
                width = Mathf.CeilToInt(height * deviceAspect);
            else if (deviceAspect < aspect)
                height = Mathf.CeilToInt(width / deviceAspect);
#endif
#if UNITY_EDITOR
            SetGameViewSize(width, height, fullScreen != FullScreenMode.Windowed);
#else
            Screen.SetResolution(width, height, fullScreen);
#endif
        }
    }
}
