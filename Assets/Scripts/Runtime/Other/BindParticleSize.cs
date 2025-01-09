using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YKGame.Runtime
{
    public class BindParticleSize : MonoBehaviour
    {
        public ParticleSystem bindTarget;
        public bool playOnEnable = true;
        public bool zeroOnEnd = true;
        private AnimationCurve curve;
        private float delay;
        private float duration;
        private float timeScale = 1f;
        public float TimeScale
        {
            set
            {
                timeScale = Mathf.Max(0.01f, value);
            }
        }

        private void OnValidate()
        {
            curve = bindTarget.sizeOverLifetime.size.curve;
            var main = bindTarget.main;
            delay = main.startDelay.constant;
            duration = main.startLifetime.constant;
        }

        private void OnEnable()
        {
            if (playOnEnable)
                Play();
        }

        // Start is called before the first frame update
        void Start()
        {
            if (curve == null)
                OnValidate();
            Play();
        }

        public void Play()
        {
            transform.localScale = Vector3.zero;
            var tween = transform.DOScale(1, duration).SetDelay(delay).SetEase(curve);
            tween.timeScale = timeScale;
            if (zeroOnEnd)
                tween.OnComplete(() => transform.localScale = Vector3.zero);
        }
    }
}
