using Cinemachine;
using System;
using UnityEngine;

namespace YKGame.Runtime
{
    [Serializable]
    public class NoiseMap
    {
        [Tooltip("设置相机的位置旋转变化曲线")]
        public NoiseSettings rawSignal;
        [Tooltip("若有多个曲线时，将会轮流按照该时间点开始执行")]
        public float timePoint;
    }

    [CreateAssetMenu(fileName = "ImpulseSetting", menuName = "ScriptableObject/震动配置", order = 0)]
    public class ImpulseSetting : ScriptableObject
    {
        [Header("震动曲线")]
        public NoiseMap[] noises;
        [Header("强度")]
        public float force = 1f;
        [Header("淡入曲线，一般不需要设置")]
        public AnimationCurve attackCurve;
        [Header("淡入时长")]
        public float attackTime = 0;
        [Header("峰值时长")]
        public float sustainTime = 0.2f;
        [Header("淡出曲线，一般不需要设置")]
        public AnimationCurve decayCurve;
        [Header("淡出时长")]
        public float decayTime = 0.7f;
        public float TotalTime => attackTime + sustainTime + decayTime;
    }
}
