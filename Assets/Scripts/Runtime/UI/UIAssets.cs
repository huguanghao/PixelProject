using FairyGUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YKGame.Runtime
{
    public class UIAssets : MonoBehaviour
    {

        public string PackageName = "";
        [SerializeField]
        public List<TextAsset> AllBytes = new List<TextAsset>();
        [SerializeField]
        public List<Texture> AllTexture2D = new List<Texture>();
        [SerializeField]
        public List<AudioClip> AllAudioClip = new List<AudioClip>();

        public UnityEngine.Object GetAsset(System.Type type, string AssetName)
        {
            if (type == typeof(TextAsset))
            {
                for (int i = 0; i < AllBytes.Count; ++i)
                {
                    //Debug.Log("AllBytes[i].name: " + AllBytes[i].name + "   ### " + AssetName);
                    if (AllBytes[i].name == AssetName)
                        return AllBytes[i];
                }
            }
            else if (type == typeof(Texture) || type == typeof(Texture2D))
            {
                for (int i = 0; i < AllTexture2D.Count; ++i)
                {
                    if (AllTexture2D[i].name == AssetName)
                        return AllTexture2D[i];
                }
            }
            else if (type == typeof(AudioClip))
            {
                for (int i = 0; i < AllAudioClip.Count; ++i)
                {
                    if (AllAudioClip[i].name == AssetName)
                        return AllAudioClip[i];
                }
            }

            return null;
        }

        private UIPackage m_package = null;

        public UIPackage Package
        {
            get
            {
                return m_package;
            }
        }
        private void Awake()
        {
            TextAsset des = GetAsset(typeof(TextAsset), PackageName + "_fui") as TextAsset;
            m_package = UIPackageManager.Instance.AddPackage(des.bytes, PackageName,
                (string name, string extension, System.Type type, out DestroyMethod destroyMethod) =>
                {
                    destroyMethod = DestroyMethod.None;
                    object asset = GetAsset(type, name);
                    return asset;
                }
            );

            //m_package.LoadAllAssets();

        }

        private void OnDestroy()
        {
            UIPackageManager.Instance.RemovePackage(PackageName);
            m_package = null;
        }
    }

}
