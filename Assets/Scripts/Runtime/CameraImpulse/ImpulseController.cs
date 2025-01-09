using Cinemachine;
using System;
using System.Collections;
using UnityEngine;

namespace YKGame.Runtime
{
    public class ImpulseController : MonoBehaviour
    {
        [Header("�𶯲���")]
        public ImpulseSetting impulseParams;
        [Header("���������뿪ʼ��")]
        public float delayTime;
        [Header("������")]
        public float gain = 1f;
        [Header("ǿ��ִ��")]
        [Tooltip("����ѡ�������𶯿�ʼʱ��������������Ա���ִ�У���֮�������ִ�б�����")]
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

