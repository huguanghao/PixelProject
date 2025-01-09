using JEngine.Core;
using System.IO;

namespace YKGameFramework
{
    public static partial class Utility
    {
        /// <summary>
        /// 资源相关路径
        /// </summary>
        public static class Asset
        {
            public const string LANG_PRELOAD_FILE = "Assets/HotUpdateResources/Main/TextAsset/Preload.txt";//多语言文件预读列表
            public const string UILANG_PATH1 = "Assets/HotUpdateResources/Main/TextAsset/UILang/";//UI多语言
            public const string UILANG_PATH2 = "Assets/HotUpdateResources/Main/TextAsset/GText/";//lang表
            public const string SINGLETON_SCRIPTABLEOBJECT = "Assets/HotUpdateResources/Main/ScriptableObject/Singleton/";//单例类型的ScriptableObject存放目录
            public static string GetSingletonScriptable(string name)
            {
                return $"{Utility.Asset.SINGLETON_SCRIPTABLEOBJECT}{name}.asset";
            }
        }
    }
}
