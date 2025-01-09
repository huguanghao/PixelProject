using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollider : MonoBehaviour
{
    public GameObject copyTargetLayer;
    public float radiusScale = 0.5f;
    [Tooltip("粒子剩余时间低于该值隐藏关闭碰撞")]
    public float hideTime = 0.8f;
    ParticleSystem ps;
    Transform colliderRoot;
    ParticleSystem.Particle[] particles = new ParticleSystem.Particle[0];
    List<SphereCollider> spheres = new List<SphereCollider>();

    // Start is called before the first frame update
    void Awake()
    {
        ps = GetComponent<ParticleSystem>();
        colliderRoot = new GameObject("Colliders").transform;
        colliderRoot.parent = transform;
        colliderRoot.localPosition = Vector3.zero;
    }

    void LateUpdate()
    {
        if(particles.Length < ps.particleCount)
            Array.Resize(ref particles, ps.particleCount);

        int count = ps.GetParticles(particles);
        for (int i = 0; i < count; i++)
        {
            ParticleSystem.Particle p = particles[i];
            if(p.remainingLifetime <= hideTime)
            {
                if (i < spheres.Count)
                    spheres[i].transform.position = new Vector3(0, -100, 0);
                continue;
            }
            SphereCollider sphere;
            if (i >= spheres.Count)
            {
                sphere = new GameObject(i.ToString()).AddComponent<SphereCollider>();
                sphere.transform.parent = colliderRoot;
                sphere.isTrigger = true;
                sphere.gameObject.layer = copyTargetLayer.layer;
                spheres.Add(sphere);
            }
            else
                sphere = spheres[i];
            //sphere.enabled = true;
            sphere.radius = p.GetCurrentSize(ps) / 2f * radiusScale;
            sphere.transform.position = p.position;
        }
        for (int i = count; i < spheres.Count; i++)
        {
            spheres[i].transform.position = new Vector3(0, -100, 0);
        }
    }
}
