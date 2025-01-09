using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Rendering;

public class AssetImportListener : UnityEditor.AssetPostprocessor
{
    bool flag;

    /// <summary>
    /// 激活状态的SortingGroup组件从子物体中移除一个Looping为false的粒子再关闭激活状态后，导入资源会报错：Invalid SortingGroup index set in Renderer
    /// <para>（先关闭激活状态，再移除粒子则不会）</para>
    /// </summary>
    private async void OnPreprocessAsset()
    {
        if (flag)
            return;
        flag = true;
        Transform root = GameObject.Find("/GameObjectPool")?.transform;
        if (root != null)
        {
            int cnt = root.childCount;
            for (int i = 0; i < cnt; i++)
            {
                var child = root.GetChild(i);
                if(!child.TryGetComponent(out SortingGroup sortingGroup))
                    sortingGroup = child.gameObject.AddComponent<SortingGroup>();
                sortingGroup.enabled = true;
                sortingGroup.enabled = false;
            }
        }
        await Task.Delay(1);
        flag= false;
    }
}
