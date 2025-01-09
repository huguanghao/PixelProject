using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using YKGameFramework;

namespace YKGame.Editor
{
    [InitializeOnLoad]
    public class CreatePreList
    {
        static CreatePreList()
        {
            EditorApplication.playModeStateChanged += ChangedPlaymodeState;
        }

        /// <summary>
        /// 会重复进入多次
        /// </summary>
        static void ChangedPlaymodeState(PlayModeStateChange playModeStateChange)
        {
            if (playModeStateChange == PlayModeStateChange.ExitingEditMode)
            {
                CreatePreloadFile();
            }
        }
        [MenuItem("Game/CreatePreloadList")]
        public static void CreatePreloadFile()
        {
            if (!File.Exists(Utility.Asset.LANG_PRELOAD_FILE))
                File.Create(Utility.Asset.LANG_PRELOAD_FILE);
            using (StreamWriter sw = new StreamWriter(Utility.Asset.LANG_PRELOAD_FILE))
            {
                string[] files;// = Directory.GetFiles(Utility.Asset.UILANG_PATH1, "*.json");
                //foreach (var filePath in files)
                //{
                //    sw.WriteLine(filePath);
                //}
                files = Directory.GetFiles(Utility.Asset.UILANG_PATH2, "*.json");
                foreach (var filePath in files)
                {
                    sw.WriteLine(filePath);
                }
            }
            AssetDatabase.Refresh();
        }
    }
}

