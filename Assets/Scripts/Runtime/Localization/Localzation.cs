using System;
using System.IO;
using System.Linq;
using UnityEngine;
using System.Globalization;
using System.Collections.Generic;
using FairyGUI;
using YKGameFramework;
using JEngine.Core;
using LitJson;
using System.Text.RegularExpressions;

namespace YKGame.Runtime
{
    public class Localzation
    {
        private class LocalLangTableLine
        {
            public string key;
            public Dictionary<string, string> value;
        }

        private static List<LocalLangTableLine> localLangTable;

        private const string CsvLoc = "TextAsset/Localization";
        private static string _language;

        public static string CurrentLanguage
        {
            get
            {
                return _language;
            }
        }

        private static void Init()
        {
            _language = PlayerPrefs.GetString(Utility.PlayerPrefs.LANGUAGE, "cs");

            var file = Resources.Load<TextAsset>(CsvLoc);
            if (file == null)
            {
                Log.PrintError("Localization模块无效，因为没有获取到表格文件");
                return;
            }

            localLangTable = JsonMapper.ToObject<List<LocalLangTableLine>>(file.text);
            Resources.UnloadAsset(file);
        }

        /// <summary>
        /// 获取key的文字,仅热更场景用
        /// Find string of key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetLocalString(string key)
        {
            if (localLangTable == null)
                Init();
            LocalLangTableLine ret = localLangTable.Find(o => o.key == key);
            if(ret != null && ret.value.ContainsKey(_language))
                return ret.value[_language];
            Log.Print($"从Localization.json中获取key:{key}失败");
            return ret.value["cs"];
        }
    }
}
