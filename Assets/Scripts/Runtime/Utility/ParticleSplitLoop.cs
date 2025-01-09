using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSplitLoop : MonoBehaviour
{
    public ParticleSystem particle;
    [Header("原本播放时长")]
    public float originalDuration;
    [Header("循环开始时间点")]
    public float loopStartTime;
    [Header("循环结束时间点")]
    public float loopEndTime;

    [Header("期望的总播放时长")]
    public float duration;

    private float timer;
    private float loopTime;

    private void OnEnable()
    {
        timer = -1f;
        loopTime = duration - (originalDuration - loopEndTime) - loopStartTime;
    }

    void Awake()
    {

    }

    private void FixedUpdate()
    {
        if (timer == -2f)
            return;
        if (timer == -1f)
        {
            if (particle.isPlaying)
                timer = 0;
            return;
        }
        timer += Time.fixedDeltaTime;
        if(timer > loopStartTime)
        {
            loopTime -= Time.fixedDeltaTime;
            if (loopTime <= 0)
            {
                timer = -2f;
                particle.Simulate(loopEndTime, true);
                particle.Play();
            }
            else if(timer >= loopEndTime)
            {
                timer = loopStartTime;
                particle.Simulate(loopStartTime, true, true);
                particle.Play();
            }
        }
    }
}
