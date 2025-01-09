using Cinemachine;
using System;
using UnityEngine;

namespace YKGame.Runtime
{
    [Serializable]
    public class NoiseMap
    {
        [Tooltip("���������λ����ת�仯����")]
        public NoiseSettings rawSignal;
        [Tooltip("���ж������ʱ�������������ո�ʱ��㿪ʼִ��")]
        public float timePoint;
    }

    [CreateAssetMenu(fileName = "ImpulseSetting", menuName = "ScriptableObject/������", order = 0)]
    public class ImpulseSetting : ScriptableObject
    {
        [Header("������")]
        public NoiseMap[] noises;
        [Header("ǿ��")]
        public float force = 1f;
        [Header("�������ߣ�һ�㲻��Ҫ����")]
        public AnimationCurve attackCurve;
        [Header("����ʱ��")]
        public float attackTime = 0;
        [Header("��ֵʱ��")]
        public float sustainTime = 0.2f;
        [Header("�������ߣ�һ�㲻��Ҫ����")]
        public AnimationCurve decayCurve;
        [Header("����ʱ��")]
        public float decayTime = 0.7f;
        public float TotalTime => attackTime + sustainTime + decayTime;
    }
}
