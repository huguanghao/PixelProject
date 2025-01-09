using FairyGUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YKGame.Runtime
{
    public class UIPackageManager:MonoBehaviour
    {
        private static UIPackageManager _instance;
        private static readonly object syslock = new object();
        private static bool isQuitting = false;
        public static UIPackageManager Instance
        {
            get
            {
                if (_instance == null && !isQuitting)
                {
                    lock (syslock)
                    {
                        if (_instance == null)
                        {
                            _instance = new GameObject("UIPackageMgr").AddComponent<UIPackageManager>();
                            DontDestroyOnLoad(_instance.gameObject);
                        }
                    }
                }
                return _instance;
            }
        }
        class RefPackage
        {
            public UIPackage package;
            public int refcount;

            public RefPackage(UIPackage package)
            {
                this.package = package;
                refcount = 1;
            }

            public void AddRef()
            {
                ++refcount;
            }

            public void SubRef()
            {
                --refcount;
            }
        }

        Dictionary<string, RefPackage> PackagePool = new Dictionary<string, RefPackage>();
        public UIPackage AddPackage(byte[] dese, string PackageName, UIPackage.LoadResource loadResource)
        {
            UIPackage package = null;
            if (!PackagePool.ContainsKey(PackageName))
            {
                package = UIPackage.AddPackage(dese, PackageName, loadResource);
                PackagePool.Add(PackageName, new RefPackage(package));
            }
            else
            {
                RefPackage ref_package = PackagePool[PackageName];
                ref_package.AddRef();
                package = ref_package.package;
            }
            return package;
        }

        public void RemovePackage(string PackageName)
        {
            if (PackagePool.ContainsKey(PackageName))
            {
                RefPackage ref_package = PackagePool[PackageName];
                ref_package.SubRef();
                if (ref_package.refcount <= 0)
                {
                    UIPackage.RemovePackage(ref_package.package.id);
                    PackagePool.Remove(PackageName);
                }
            }
        }
        public void SetButtonSound(string url)
        {
            UIConfig.buttonSound = UIPackage.GetItemAssetByURL(url) as NAudioClip;
        }

        private void OnDestroy()
        {
            foreach (KeyValuePair<string, RefPackage> kv in PackagePool)
            {
                UIPackage.RemovePackage(kv.Value.package.id);
            }
            PackagePool.Clear();
        }

        private void OnApplicationQuit()
        {
            isQuitting = true;
            PackagePool.Clear();
        }
    }

}
