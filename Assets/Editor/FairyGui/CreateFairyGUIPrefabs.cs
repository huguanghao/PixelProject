using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using System.Linq;
using YKGame.Runtime;
using YKGameFramework;

namespace YKGame.Editor
{
    [InitializeOnLoad]
    class CreateFairyGUIPrefabs
    {
        static CreateFairyGUIPrefabs()
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
                CreatenewPrefabs();
            }
        }
        static Dictionary<string, UnityEngine.Object> AssetDic = new Dictionary<string, UnityEngine.Object>();

        private static T LoadAsset<T>(string assetName) where T : UnityEngine.Object
        {
            T o = AssetDatabase.LoadAssetAtPath<T>(assetName);
            return o;
        }
        
        private static string resPath = "Assets/HotUpdateResources/Main/UI/Res/"; //输出目录
        private static string OutPrefabsPath = "Assets/HotUpdateResources/Main/UI/Prefabs"; //输出目录
        [MenuItem("Game/CreateFairyGUIPrefabs", false, 11)]
        public static void CreatenewPrefabs()
        {
            string[] resPaths = { "Assets/HotUpdateResources/Main/UI/Res/", "Assets/Resources/UI/Res/" };
            string[] OutPrefabsPaths = { "Assets/HotUpdateResources/Main/UI/Prefabs", "Assets/Resources/UI/Prefabs" };
            List<string> prefabList = new List<string>();
            for (int j = 0; j < 2; ++j)
            {
                resPath = resPaths[j];
                OutPrefabsPath = OutPrefabsPaths[j];
                if (!Directory.Exists(OutPrefabsPath))
                {
                    Directory.CreateDirectory(OutPrefabsPath);
                }

                string[] metaFiles = Directory.GetFiles(resPath, "*.meta", SearchOption.AllDirectories);

                for (int i = 0; i < metaFiles.Length; ++i)
                {
                    string str = File.ReadAllText(metaFiles[i]);
                    if (!str.Contains("guid:"))
                    {
                        Debug.LogError("检查到meta没有生成guid 删除meta重新生成: " + metaFiles[i]);
                        File.Delete(metaFiles[i]);
                    }
                }

                AssetDatabase.Refresh();

                string[] fileNames = Directory.GetFiles(resPath, "*_fui.bytes", SearchOption.AllDirectories);
                for (int i = 0; i < fileNames.Length; ++i)
                {
                    bool refresh = false;
                    string assetpath = fileNames[i];
                    string fileName = Path.GetFileNameWithoutExtension(assetpath);
                    string prefabName = fileName.Replace("_fui", "");

                    string OutPrefabPathName = Utility.Path.GetRegularPath(Path.Combine(OutPrefabsPath, prefabName + ".prefab"));
                    prefabList.Add(OutPrefabPathName);
                    GameObject prefab;
                    if (!File.Exists(OutPrefabPathName))
                    {
                        GameObject go = new GameObject();
                        go.name = prefabName;
                        prefab = PrefabUtility.SaveAsPrefabAsset(go, OutPrefabPathName);
                        GameObject.DestroyImmediate(go);
                    }
                    else
                    {
                        prefab = LoadAsset<GameObject>(OutPrefabPathName);
                    }
                    if (!prefab.TryGetComponent<UIAssets>(out UIAssets uiAssets))
                        uiAssets = prefab.AddComponent<UIAssets>();
                    uiAssets.PackageName = prefabName;
                    if (assetpath.Contains("Assets/Resources/UI/Res/") && "loading_1000".CompareTo(prefabName) == 0)
                    {
                        if (!prefab.TryGetComponent<LoadingUI>(out var loading))
                            loading = prefab.AddComponent<LoadingUI>();
                    }

                    string[] assets = Directory.GetFiles(resPath, prefabName + "_atlas" + "*.png", SearchOption.AllDirectories);
                    if (uiAssets.AllTexture2D.Count != assets.Length)
                    {
                        refresh = true;
                        uiAssets.AllTexture2D.Clear();
                        for (int k = 0; k < assets.Length; ++k)
                        {
                            string path = assets[k];

                            TextureImporter textureImporter = TextureImporter.GetAtPath(path) as TextureImporter;
                            if (textureImporter == null)
                            {
                                Debug.LogError("不是图集: " + path);
                            }
                            else if (textureImporter.mipmapEnabled)
                            {
                                textureImporter.mipmapEnabled = false;
                                AssetDatabase.ImportAsset(path);
                            }
                            Texture texture = LoadAsset<Texture>(path);
                            uiAssets.AllTexture2D.Add(texture);
                        }
                    }

                    assets = Directory.GetFiles(resPath, prefabName + "_fui" + "*.bytes", SearchOption.AllDirectories);
                    if (uiAssets.AllBytes.Count != assets.Length)
                    {
                        refresh = true;
                        uiAssets.AllBytes.Clear();
                        for (int k = 0; k < assets.Length; ++k)
                        {
                            string path = assets[k];
                            TextAsset textAsset = LoadAsset<TextAsset>(path);
                            uiAssets.AllBytes.Add(textAsset);
                        }
                    }

                    assets = Directory.GetFiles(resPath, prefabName + "*.wav", SearchOption.AllDirectories);
                    if (uiAssets.AllAudioClip.Count != assets.Length)
                    {
                        refresh = true;
                        uiAssets.AllAudioClip.Clear();
                        for (int k = 0; k < assets.Length; ++k)
                        {
                            string path = assets[k];
                            AudioClip audioClip = LoadAsset<AudioClip>(path);
                            uiAssets.AllAudioClip.Add(audioClip);
                        }
                    }
                    if (refresh)
                        PrefabUtility.SavePrefabAsset(prefab);
                }
            }
            AssetDatabase.ForceReserializeAssets(prefabList, ForceReserializeAssetsOptions.ReserializeAssets);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        static void ClearPrefabs()
        {
            string[] fileNames = Directory.GetFiles(OutPrefabsPath, "*.prefab", SearchOption.AllDirectories);
            for (int i = 0; i < fileNames.Length; ++i)
            {
                GameObject go = LoadAsset<GameObject>(fileNames[i]);
                if (!go.TryGetComponent<UIAssets>(out UIAssets uIAssets))
                    uIAssets = go.AddComponent<UIAssets>();
                uIAssets.AllAudioClip.Clear();
                uIAssets.AllBytes.Clear();
                uIAssets.AllTexture2D.Clear();
            }
        }
       
        private static void CreatePrefabs(string[] Paths)
        {
            if (!Directory.Exists(OutPrefabsPath))
                Directory.CreateDirectory(OutPrefabsPath);
            Dictionary<string, GameObject> prefabDic = new Dictionary<string, GameObject>();
            Dictionary<string, GameObject> prefabAssetDic = new Dictionary<string, GameObject>();
            for (int i = 0; i < Paths.Length; ++i)
            {
                string assetpath = Paths[i];
                string extension = Path.GetExtension(assetpath);

                string guid = AssetDatabase.AssetPathToGUID(assetpath);

                if (string.IsNullOrEmpty(guid))
                {
                    Debug.LogError("fuck 没有guid: " + assetpath);
                }

                if (assetpath.Contains(resPath))
                {
                    string name = Path.GetFileNameWithoutExtension(assetpath);
                    string prefabName = name.Replace("_fui", ""); 
                    int index = prefabName.IndexOf("_atlas");
                    if (index != -1)
                    {
                        prefabName = prefabName.Substring(0, index);
                    }
                    string OutPrefabPathName = Utility.Path.GetRegularPath(Path.Combine(OutPrefabsPath, prefabName + ".prefab"));
                    GameObject prefab = null;
                    GameObject prefab_asset = null;
                    if (!File.Exists(OutPrefabPathName))
                    {
                        GameObject go = new GameObject();
                        go.name = prefabName;
                        Debug.Log("OutPrefabPathName: " + OutPrefabPathName);
                        prefab_asset = PrefabUtility.SaveAsPrefabAsset(go, OutPrefabPathName);
                        prefab = PrefabUtility.InstantiatePrefab(prefab_asset) as GameObject;
                        prefabDic.Add(OutPrefabPathName, prefab);
                        prefabAssetDic.Add(OutPrefabPathName, prefab_asset);
                        GameObject.DestroyImmediate(go);
                    }
                    else
                    {
                        if (prefabDic.ContainsKey(OutPrefabPathName))
                        {
                            prefab = prefabDic[OutPrefabPathName];
                            prefab_asset = prefabAssetDic[OutPrefabPathName];
                        }
                        else
                        {
                            prefab_asset = LoadAsset<GameObject>(OutPrefabPathName);
                            prefabAssetDic.Add(OutPrefabPathName, prefab_asset);
                            prefab = PrefabUtility.InstantiatePrefab(prefab_asset) as GameObject;
                            prefabDic.Add(OutPrefabPathName, prefab);
                        }
                    }

                    if (prefab == null)
                    {
                        Debug.LogError("OutPrefabPathName: " + OutPrefabPathName);
                    }

                    if (!prefab.TryGetComponent<UIAssets>(out UIAssets uIAssets))
                        uIAssets = prefab.AddComponent<UIAssets>();
                    uIAssets.PackageName = prefabName;

                    if (extension == ".bytes")
                    {
                        TextAsset textAsset = LoadAsset<TextAsset>(assetpath);
                        if (!uIAssets.AllBytes.Contains(textAsset))
                            uIAssets.AllBytes.Add(textAsset);
                    }
                    else if (extension == ".png")
                    {
                        Texture texture = LoadAsset<Texture>(assetpath);
                        if (!uIAssets.AllTexture2D.Contains(texture))
                            uIAssets.AllTexture2D.Add(texture);
                    }
                    else if (extension == ".wav")
                    {
                        AudioClip audio = LoadAsset<AudioClip>(assetpath);
                        if (!uIAssets.AllAudioClip.Contains(audio))
                            uIAssets.AllAudioClip.Add(audio);
                    }

                }
            }


            foreach (KeyValuePair<string, GameObject> kv in prefabDic)
            {
                PrefabUtility.SaveAsPrefabAssetAndConnect(prefabAssetDic[kv.Key], kv.Key,InteractionMode.AutomatedAction);//PrefabUtility.ReplacePrefab(kv.Value, prefabAssetDic[kv.Key], ReplacePrefabOptions.ConnectToPrefab);
            }


            AssetDatabase.Refresh();
            AssetDatabase.SaveAssets();

            foreach (KeyValuePair<string, GameObject> kv in prefabDic)
            {
                GameObject.DestroyImmediate(kv.Value);
            }
            prefabDic.Clear();
            prefabAssetDic.Clear();
        }
    }

}

