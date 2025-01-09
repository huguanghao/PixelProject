using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace YKGame.Runtime 
{
    public enum FlipMethodType
    {
        None,
        FlipByRotate,
        FlipByScaleX,
    }

    [Serializable]
    public class FlipConfig
    {
        public string assetPath;
        public FlipMethodType type;
    }

    public class FlipMethodConfigData : ScriptableObject
    {
        [SerializeField]
        public List<FlipConfig> list;

        [NonSerialized]
        private Dictionary<string, FlipConfig> config;

        public Dictionary<string, FlipConfig> Config
        {
            get
            {
                if (config == null)
                {
                    config = new Dictionary<string, FlipConfig>();
                    if(list != null)
                    {
                        int cnt = list.Count;
                        for (int i = 0; i < cnt; i++)
                        {
                            config.Add(list[i].assetPath, list[i]);
                        }
                    }
                }
                return config;
            }
        }

#if UNITY_EDITOR
        public FlipConfig GetOrCreate(string assetPath)
        {
            list ??= new List<FlipConfig>();
            int cnt = list.Count;
            for (int i = 0; i < cnt; i++)
            {
                if (list[i].assetPath == assetPath)
                    return list[i];
            }
            var ret = new FlipConfig() { assetPath = assetPath };
            list.Add(ret);
            if (config != null)
                config.Add(ret.assetPath, ret);
            return ret;
        }

        /// <summary>
        /// 移除不存在的资源
        /// </summary>
        public void RemoveInvalid()
        {
            list?.RemoveAll(cfg => {
                if (AssetDatabase.GUIDFromAssetPath(cfg.assetPath).Empty())
                {
                    if (config != null)
                        config.Remove(cfg.assetPath);
                    return true;
                }
                return false;
            });
        }
#endif
    }
}
