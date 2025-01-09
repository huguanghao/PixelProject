using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace YKGame.Editor
{
    public class WeaponPrefab
    {
        static string outPutPath = "Assets/HotUpdateResources/Main/Role/Prefabs";
        static string sourcePath = "Assets/HotUpdateResources/Main/Role/Res/equip";
        static string materialPath = "Assets/HotUpdateResources/Main/Role/SpriteOutline.mat";
        [MenuItem("Game/生成预制体/武器")]
        public static void Create()
        {
            var allAssets = AssetDatabase.GetAllAssetPaths().Where(path => path.StartsWith(sourcePath) || path.StartsWith(outPutPath)).ToArray();
            Material material = AssetDatabase.LoadAssetAtPath<Material>(materialPath);

            GameObject go = new GameObject();
            go.transform.position = Vector3.zero;
            Transform model = new GameObject("model").transform;
            model.SetParent(go.transform, false);
            model.localEulerAngles = new Vector3(90f, 0f, 0f);
            Transform center = new GameObject("center").transform;
            center.SetParent(model, false);

            SpriteRenderer spriteRender = model.gameObject.AddComponent<SpriteRenderer>();
            spriteRender.sharedMaterial = material;

            int cnt = allAssets.Length;
            for (int i = 0; i < cnt; i++)
            {
                var assetPath = allAssets[i];
                if (!assetPath.StartsWith(sourcePath))
                    continue;
                string spriteName = Path.GetFileNameWithoutExtension(assetPath);
                string name;
                bool melee = false;
                if (spriteName.StartsWith("icon_skill_"))
                {
                    name = $"ap_{spriteName.Substring("icon_skill_".Length)}";
                }
                else if(spriteName.StartsWith("melee_"))
                {
                    melee = true;
                    string str = spriteName.Substring("melee_".Length);
                    name = $"ap_weapon_{str[0]}{str.Substring(str.IndexOf('_'))}";
                }
                else if(spriteName.StartsWith("range_"))
                {
                    string str = spriteName.Substring("melee_".Length);
                    name = $"ap_weapon_{str[0]}{str.Substring(str.IndexOf('_'))}";
                }
                else
                    continue;
                string outPut = $"{outPutPath}/{name}.prefab";
                if (Array.IndexOf(allAssets, outPut) != -1)
                {
                    var p = AssetDatabase.LoadAssetAtPath<GameObject>(outPut);
                    if(p.transform.localScale != Vector3.one)
                    {
                        var m = p.transform.Find("model");
                        m.localScale = m.lossyScale;
                        p.transform.localScale = Vector3.one;
                    }
                    continue;
                }
                var sprite = AssetDatabase.LoadAssetAtPath<Sprite>(assetPath);
                spriteRender.sprite = sprite;

                //保存
                var prefab = PrefabUtility.SaveAsPrefabAsset(go, outPut);
                if (melee)
                {
                    prefab.AddComponent<BoxCollider>().isTrigger = true;
                    //PrefabUtility.SaveAsPrefabAsset(prefab, outPut);
                }
                Debug.Log($"format complete: {sourcePath}/{spriteName}.png");
            }
            GameObject.DestroyImmediate(go);
        }
    }
}
