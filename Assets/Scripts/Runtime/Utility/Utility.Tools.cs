using JEngine.Core;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AI;

namespace YKGameFramework
{
    public static partial class Utility
    {
        public static void StopEditor()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }

        public static bool GetNavMeshSamplePos(Vector3 origin, out Vector3 ret, float distance, int areaMask)
        {
            if (NavMesh.SamplePosition(origin, out NavMeshHit hit, distance, areaMask))
            {
                ret = hit.position;
                return true;
            }
            ret = Vector3.zero;
            return false;
        }

        public static bool RaycastHitPoint(this NavMeshAgent agent,Vector3 to, out Vector3 point)
        {
            if (agent.Raycast(to, out NavMeshHit hit)) 
            {
                point = hit.position;
                return true;
            }
            point = Vector3.zero;
            return false;
        }

        public static bool NavMeshRayCast(Vector3 from, Vector3 to, out Vector3 point, int areaMask)
        {
            if (NavMesh.Raycast(from, to, out NavMeshHit hit, areaMask)) 
            {
                point = hit.position;
                return true;
            }
            point = Vector3.zero;
            return false;
        }

        public static bool NavMeshRayCast(Vector3 from, Vector3 to, out Vector3 point, out Vector3 normal, int areaMask)
        {
            if (NavMesh.Raycast(from, to, out NavMeshHit hit, areaMask)) 
            {
                point = hit.position;
                normal = hit.normal;
                return true;
            }
            point = Vector3.zero;
            normal = Vector3.zero;
            return false;
        }

        public static bool Compare<T>(T a,T b)where T : IEquatable<T>
        {
            return a.Equals(b);
        }

        public static void Foreach<TKey, TValue>(this Dictionary<TKey,TValue> dic,Action<TKey, TValue> action)
        {
            foreach (var kv in dic)
            {
                action.Invoke(kv.Key, kv.Value);
            }
        }
    }
}
