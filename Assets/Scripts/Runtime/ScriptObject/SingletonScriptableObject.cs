using JEngine.Core;
using UnityEngine;
using YKGame.Runtime;
using YKGameFramework;
using System;
using System.ComponentModel;

#if UNITY_EDITOR
using UnityEditor;
#endif

public static class SingletonScriptableObject<T> where T : ScriptableObject
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                string path = GetSavePath();
#if UNITY_EDITOR
                if (Application.isPlaying)
                    instance = AssetMgr.Load<T>(path);
                else
                    instance = AssetDatabase.LoadAssetAtPath<T>(path);
#else
                instance = AssetMgr.Load<T>(path);
#endif
            }
            if (instance == null)
                instance = ScriptableObject.CreateInstance<T>();
            return instance; 
        }
    }

    public static void Reload()
    {
        instance = null;
        _ = Instance;
    }

    private static string GetSavePath()
    {
        Type type = typeof(T);
#if UNITY_EDITOR
        object[] customAttributes = type.GetCustomAttributes(inherit: true);
        object[] array = customAttributes;
        foreach (object obj in array)
        {
            if (obj is DescriptionAttribute)
            {
                DescriptionAttribute descriptionAttribute = obj as DescriptionAttribute;
                return descriptionAttribute.Description;
            }
        }
#endif
        return Utility.Asset.GetSingletonScriptable(type.Name);
    }

#if UNITY_EDITOR
    public static void Save()
    {
        _ = Instance;
        if (instance != null)
        {
            string path = GetSavePath();
            instance = UnityEngine.Object.Instantiate(instance);
            AssetDatabase.CreateAsset(instance, path);
        }
    }

    public static bool Focus()
    {
        string path = GetSavePath();
        var obj = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path);
        if (obj != null)
        {
            Selection.activeObject = obj;
            return true;
        }
        return false;
    }
#endif
}
