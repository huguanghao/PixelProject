using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSplitLoop : MonoBehaviour
{
    public ParticleSystem particle;
    [Header("ԭ������ʱ��")]
    public float originalDuration;
    [Header("ѭ����ʼʱ���")]
    public float loopStartTime;
    [Header("ѭ������ʱ���")]
    public float loopEndTime;

    [Header("�������ܲ���ʱ��")]
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
