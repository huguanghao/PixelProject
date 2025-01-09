using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Rendering;

public class AssetImportListener : UnityEditor.AssetPostprocessor
{
    bool flag;

    /// <summary>
    /// ����״̬��SortingGroup��������������Ƴ�һ��LoopingΪfalse�������ٹرռ���״̬�󣬵�����Դ�ᱨ��Invalid SortingGroup index set in Renderer
    /// <para>���ȹرռ���״̬�����Ƴ������򲻻ᣩ</para>
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
