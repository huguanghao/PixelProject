using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace YKGame.Runtime
{
    /// <summary>
    /// 记录物体包围盒Size信息，用于特效附加给模型时，调整根据目标体积等比例缩放特效（例如冻结特效的体积需要根据目标大小进行缩放）
    /// </summary>
    public class ScaleMatch : MonoBehaviour
    {
        [HideInInspector]
        public float height;
#if UNITY_EDITOR
        [TextArea()]
        public string tips = "※用来记录特效的高度。当在模型上挂特效时会缩放特效使特效高度与目标模型的碰撞器的高度保持一致，从而适配不同体型的模型";
        [Header("测量目标")]
        public Transform target;
        [Header("顶部偏移")]
        public float top;
        [Header("底部偏移")]
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
