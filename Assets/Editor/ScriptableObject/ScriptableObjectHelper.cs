using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using YKGameFramework;

namespace YKGameEditor
{
    public static class ScriptableObjectHelper
    {
        [MenuItem("Assets/����ScriptableObject����")]
        private static void CreateScriptableObjectAsset()
        {
            UnityEngine.Object obj = Selection.activeObject;
            if (obj is MonoScript scriptAsset)
            {
                Type script = scriptAsset.GetClass();
                if (script.IsSubclassOf(typeof(ScriptableObject)))
                {
                    MethodInfo methodInfo = typeof(ScriptableObjectHelper).GetMethod("CreateScriptableObject").MakeGenericMethod(script);
                    obj = (UnityEngine.Object)methodInfo.Invoke(null, new object[] { Utility.Asset.SINGLETON_SCRIPTABLEOBJECT });
                    Selection.activeObject = obj;
                    return;
                }
            }
            Debug.LogError("��Ҫ��ѡ��һ���̳�ScriptableObject��cs�ű�");
        }

        /// <summary>
        /// ��Ŀ��·�����һ򴴽�ScriptableObject
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T CreateScriptableObject<T>(string path) where T : ScriptableObject
        {
            path = $"{path}/{typeof(T).Name}.asset";
            T asset = AssetDatabase.LoadAssetAtPath<T>(path);
            if (asset == null)
            {
                asset = ScriptableObject.CreateInstance<T>();
                AssetDatabase.CreateAsset(asset, path);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
            Selection.activeObject = asset;
            return asset;
        }
    }
}