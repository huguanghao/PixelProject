using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace YKGame.Runtime
{
    /// <summary>
    /// ��¼�����Χ��Size��Ϣ��������Ч���Ӹ�ģ��ʱ����������Ŀ������ȱ���������Ч�����綳����Ч�������Ҫ����Ŀ���С�������ţ�
    /// </summary>
    public class ScaleMatch : MonoBehaviour
    {
        [HideInInspector]
        public float height;
#if UNITY_EDITOR
        [TextArea()]
        public string tips = "��������¼��Ч�ĸ߶ȡ�����ģ���Ϲ���Чʱ��������Чʹ��Ч�߶���Ŀ��ģ�͵���ײ���ĸ߶ȱ���һ�£��Ӷ����䲻ͬ���͵�ģ��";
        [Header("����Ŀ��")]
        public Transform target;
        [Header("����ƫ��")]
        public float top;
        [Header("�ײ�ƫ��")]
        public float bottom;

        private void Awake()
        {
            target = transform;
        }

        private void OnDrawGizmosSelected()
        {
            if (target == null)
                return;
            Gizmos.color = Color.green;
            height = top - bottom;
            Vector3 center = target.position;
            center.z = (top + bottom) / 2;
            Gizmos.DrawLine(center - target.right * 2 + target.up * height / 2, center + target.right * 2 + target.up * height / 2);
            Gizmos.DrawLine(center - target.right * 2 - target.up * height / 2, center + target.right * 2 - target.up * height / 2);
            Gizmos.DrawLine(center + target.up * height / 2, center - target.up * height / 2);
        }
#endif
    }
}
