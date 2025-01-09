using Cinemachine;
using System;
using System.Collections;
using UnityEngine;

namespace YKGame.Runtime
{
    public class ImpulseController : MonoBehaviour
    {
        [Header("震动参数")]
        public ImpulseSetting impulseParams;
        [Header("激活后多少秒开始震动")]
        public float delayTime;
        [Header("震动缩放")]
        public float gain = 1f;
        [Header("强制执行")]
        [Tooltip("不勾选：若该震动开始时相机正在震动则会忽略本次执行；反之则会优先执行本次震动")]
        public bool force;

        private void OnEnable()
        {
            if(delayTime > 0)
            {
                StartCoroutine(ShakeDelay());
            }
            else
                ImpulseManager.Instance.Shake(impulseParams, force, gain);
        }

        private void OnDisable()
        {
            StopAllCoroutines();
        }

        private IEnumerator ShakeDelay()
        {
            yield return new WaitForSeconds(delayTime);
            ImpulseManager.Instance.Shake(impulseParams, force, gain);
        }
    }
}

