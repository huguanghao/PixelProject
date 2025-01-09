using JEngine.Core;
using System.IO;

namespace YKGameFramework
{
    public static partial class Utility
    {
        /// <summary>
        /// 存放类UnityEngine.PlayerPrefs保存的key值
        /// </summary>
        public static class PlayerPrefs
        {
            public const string LANGUAGE = "YKGame.Runtime.language";
            public const string ResolutionWidth = "YKGame.Runtime.resolution_width";
            public const string ResolutionHeight = "YKGame.Runtime.resolution_height";
            public const string ResolutionType = "YKGame.Runtime.resolution_screen_type";
        }
    }
}
