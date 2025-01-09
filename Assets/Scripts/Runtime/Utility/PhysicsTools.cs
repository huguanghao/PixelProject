using Cinemachine.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using YKGame.Runtime;

namespace YKGameFramework
{
    public static class PhysicsTools
    {
        private static bool isRayCast;
        private static Collider[] colliders = new Collider[0];
        private static HashSet<Collider> selectCollider;
        private static RaycastHit[] raycastHits = new RaycastHit[0];
        private static int[] resultsIndexs = new int[0];
        private static HashSet<Collider> ignoreList = new HashSet<Collider>();
        private static HashSet<Rigidbody> ignoreRigidbody = new HashSet<Rigidbody>();
        private static int resultCount;

        private static Func<Collider, bool> _selection;

        public static int MaxCount = raycastHits.Length;
        
        public static int ResultCount => resultCount;
        public static int IgnoreListCount => ignoreList.Count;
        public static bool IgnoreIsEnable => _selection != null || ignoreList.Count > 0;

        const int defaulLength = 50;
        static PhysicsTools()
        {
            selectCollider = new HashSet<Collider>();
            SetRaycastHitSize(defaulLength);
        }

        public static void SetRaycastHitSize(int length)
        {
            Array.Resize(ref raycastHits, length);
            Array.Resize(ref resultsIndexs, length);
            Array.Resize(ref colliders, length);
        }

        /// <summary>
        /// 每次检测前设置筛选器，排除返回true的碰撞器
        /// </summary>
        /// <param name="action"></param>
        public static void IgnoreCollider(Func<Collider, bool> action)
        {
            _selection = action;
        }

        /// <summary>
        /// 检测前设置要忽略的刚体（如果未在同一帧设置回detectCollisions=true，会导致触发OnTriggerEnter、OnCollisionEnter等方法）
        /// </summary>
        /// <param name="rigid"></param>
        public static void IgnoreRigidbody(Rigidbody rigid)
        {
            if (rigid == null)
                return;
            else if(rigid.detectCollisions)
            {
                ignoreRigidbody.Add(rigid);
                rigid.detectCollisions = false;
            }
            else
                Debug.LogWarning($"传入了一个已经关闭碰撞的Rigidbody!!! 请排查是否有误", rigid);
        }

        /// <summary>
        /// 检测前设置忽略的刚体（如果未在同一帧设置回detectCollisions=true，会导致OnTriggerEnter、OnCollisionEnter等方法）
        /// </summary>
        /// <param name="rigid"></param>
        public static void IgnoreRigidbody(Collider coll)
        {
            if (coll != null)
                IgnoreRigidbody(coll.attachedRigidbody);
        }

        public static void ClearIgnoreList()
        {
            ignoreList.Clear();
        }

        public static void IgnornCollider(bool ignore, Collider collider)
        {
            if(collider != null)
            {
                if (ignore)
                    ignoreList.Add(collider);
                else
                    ignoreList.Remove(collider);
            }
        }

        public static void IgnornCollider(bool ignore, Collider coll1, Collider coll2)
        {
            IgnornCollider(ignore, coll1);
            IgnornCollider(ignore, coll2);
        }

        public static void IgnornCollider(bool ignore, params Collider[] colls)
        {
            for (int i = 0; i < colls.Length; i++)
                IgnornCollider(ignore, colls[i]);
        }

        public static void OrderByDistance(int count = 0)
        {
            if (isRayCast)
            {
                if (count <= 0 || count > resultCount)
                    count = resultCount;
                for (int i = 0; i < count; i++)
                {
                    for (int j = resultCount - 1; j > i; j--)
                    {
                        if(GetDistanceAt(j) < GetDistanceAt(j - 1))
                        {
                            int t = resultsIndexs[j];
                            resultsIndexs[j] = resultsIndexs[j - 1];
                            resultsIndexs[j - 1] = t;
                        }
                    }
                }
            }
        }

        public static RaycastHit GetResultAt(int index)
        {
            return raycastHits[resultsIndexs[index]];
        }

        public static Collider GetColliderAt(int index = 0)
        {
            return isRayCast ? GetResultAt(index).collider : colliders[resultsIndexs[index]];
        }

        public static Vector3 GetPointAt(int index = 0)
        {
            return GetResultAt(index).point;
        }

        public static Vector3 GetNormalAt(int index = 0)
        {
            return GetResultAt(index).normal;
        }

        public static Rigidbody GetRigidbodyAt(int index = 0)
        {
            return GetResultAt(index).rigidbody;
        }

        public static Transform GetTransformAt(int index = 0)
        {
            return GetResultAt(index).transform;
        }

        public static float GetDistanceAt(int index = 0)
        {
            return GetResultAt(index).distance;
        }

        private static void RemoveIgnorn(bool isRayCast = true)
        {
            PhysicsTools.isRayCast = isRayCast;
            int index = 0;
            for (int i = 0; i < resultCount; i++)
            {
                Collider coll = isRayCast ? raycastHits[i].collider : colliders[i];
                if (ignoreList.Contains(coll) || _selection != null && _selection.Invoke(coll))
                    continue;
                resultsIndexs[index++] = i;
            }
            resultCount = index;
            ResetIgnore();
        }

        public static void ResetIgnore()
        {
            ClearIgnoreList();
            _selection = null;
            foreach (var rigid in ignoreRigidbody)
            {
                rigid.detectCollisions = true;
            }
            ignoreRigidbody.Clear();
        }

        public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask)
        {
            resultCount = Physics.BoxCastNonAlloc(center, halfExtents, direction, raycastHits, orientation, maxDistance, layerMask);
            RemoveIgnorn();
            return resultCount;
        }
        public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask)
        {
            resultCount = Physics.CapsuleCastNonAlloc(point1, point2, radius, direction, raycastHits, maxDistance, layerMask);
            RemoveIgnorn();
            return resultCount;
        }
        public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask)
        {
            resultCount = Physics.SphereCastNonAlloc(origin, radius, direction, raycastHits, maxDistance, layerMask);
            RemoveIgnorn();
            return resultCount;
        }
        public static int RayCastNonAlloc(Vector3 origin, Vector3 direction, float distance, int layerMask)
        {
            resultCount = Physics.RaycastNonAlloc(origin, direction, raycastHits, distance, layerMask);
            RemoveIgnorn();
            return resultCount;
        }
        public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask)
        {
            if(Physics.BoxCast(center, halfExtents, direction, out raycastHits[0], orientation, maxDistance, layerMask))
            {
                resultCount = 1;
                RemoveIgnorn();
                return resultCount > 0;
            }
            return false;
        }
        public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask)
        {
            if(Physics.SphereCast(origin, radius, direction, out raycastHits[0], maxDistance, layerMask))
            {
                resultCount = 1;
                RemoveIgnorn();
                return resultCount > 0;
            }
            return false;
        }
        public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask)
        {
            if (Physics.CapsuleCast(point1, point2, radius, direction, out raycastHits[0], maxDistance, layerMask))
            {
                resultCount = 1;
                RemoveIgnorn();
                return resultCount > 0;
            }
            return false;
        }

        /// <summary>
        /// 带角度限制的球行投射检查
        /// </summary>
        public static void SphereAngleCastNonAlloc(Vector3 center, Vector3 upAxis, Vector3 direction, float angle, float radius, List<Collider> hitInfos, int layerMask, float height = -1f)
        {
            hitInfos.Clear();
            if (angle <= 0)
                return;
            radius = Mathf.Abs(radius);
            angle /= 2f;
            if (height <= 0)
                height = radius * 2;
            Vector3 dir = Quaternion.AngleAxis(-angle, upAxis) * direction;
            Vector3 pos = center + dir * radius / 2f + Quaternion.AngleAxis(90, upAxis) * dir * 0.05f;
            Vector3 halfExtents = new Vector3(0.005f, height / 2f, radius / 2f);
            int count = Physics.OverlapBoxNonAlloc(pos, halfExtents, colliders, Quaternion.LookRotation(dir, upAxis), layerMask);
            for (int i = 0; i < count; i++)
            {
                selectCollider.Add(colliders[i]);
            }
            dir = Quaternion.AngleAxis(angle, upAxis) * direction;
            pos = center + dir * radius / 2f + Quaternion.AngleAxis(-90, upAxis) * dir * 0.05f;
            count = Physics.OverlapBoxNonAlloc(pos, halfExtents, colliders, Quaternion.LookRotation(dir, upAxis), layerMask);
            for (int i = 0; i < count; i++)
            {
                selectCollider.Add(colliders[i]);
            }
            hitInfos.AddRange(selectCollider);
            count = Physics.SphereCastNonAlloc(center + upAxis * height, radius, -upAxis, raycastHits, height, layerMask);
            for (int i = 0; i < count; i++)
            {
                RaycastHit hit = raycastHits[i];
                if (!selectCollider.Contains(hit.collider))
                {
                    float a = Vector3.SignedAngle(hit.point - center, direction, upAxis);
                    if (Mathf.Abs(a) <= angle)
                        hitInfos.Add(hit.collider);
                }
            }
            selectCollider.Clear();

            for (int i = hitInfos.Count - 1; i >= 0; i--)
            {
                if (ignoreList.Contains(hitInfos[i]) || _selection != null && _selection.Invoke(hitInfos[i]))
                    hitInfos.RemoveAt(i);
            }
            ResetIgnore();
        }

        public static int OverlapBoxNonAlloc(Vector3 position,Vector3 halfExtents,Quaternion rotation,int layerMask)
        {
            resultCount = Physics.OverlapBoxNonAlloc(position, halfExtents, colliders, rotation, layerMask);
            RemoveIgnorn(false);
            return resultCount;
        }

        public static int OverlapCapsuleNonAlloc(Vector3 point1, Vector3 point2, float radius, float height,int layerMask)
        {
            resultCount = Physics.OverlapCapsuleNonAlloc(point1, point2, radius, colliders, layerMask);
            RemoveIgnorn(false);
            return resultCount;
        }

        public static int OverlapSphereNonAlloc(Vector3 center,float radius,int layerMask)
        {
            resultCount = Physics.OverlapSphereNonAlloc(center, radius, colliders, layerMask);
            RemoveIgnorn(false);
            return resultCount;
        }

        public static int OverlapNoAlloc(Collider collider, int layerMask)
        {
            switch (collider)
            {
                case SphereCollider sphere:
                    return OverlapSphereNonAlloc(collider.transform.TransformPoint(sphere.center), sphere.radius * collider.transform.lossyScale.GetMax(), layerMask);
                case BoxCollider box:
                    return OverlapBoxNonAlloc(collider.transform.TransformPoint(box.center), box.GetActualHalfSize(), collider.transform.rotation, layerMask);
                case CapsuleCollider capsule:
                    Vector3 center = capsule.transform.TransformPoint(capsule.center);
                    Vector3 axis = capsule.GetStatus(out float radius, out float height);
                    Vector3 point1 = center + axis * height / 2;
                    Vector3 point2 = center - axis * height / 2;
                    return OverlapCapsuleNonAlloc(point1, point2, radius, height, layerMask);
            }
            return 0;
        }

        public static int CastNoAlloc(Collider collider, Vector3 origin, Vector3 direction, float distance, int layerMask)
        {
            switch (collider)
            {
                case SphereCollider sphere:
                    return SphereCastNonAlloc(origin, sphere.radius * collider.transform.lossyScale.GetMax(), direction, distance, layerMask);
                case BoxCollider box:
                    return BoxCastNonAlloc(origin, box.GetActualHalfSize(), direction, collider.transform.rotation, distance, layerMask);
                case CapsuleCollider capsule:
                    Vector3 axis = capsule.GetStatus(out float radius, out float height);
                    Vector3 point1 = origin + axis * height / 2;
                    Vector3 point2 = origin - axis * height / 2;
                    return CapsuleCastNonAlloc(point1, point2, radius, direction, distance, layerMask);
            }
            return 0;
        }

        public static Vector3 GetCenterWorldPosition(this Collider collider)
        {
            switch (collider)
            {
                case SphereCollider sphere:
                    return collider.transform.TransformPoint(sphere.center);
                case BoxCollider box:
                    return collider.transform.TransformPoint(box.center);
                case CapsuleCollider capsule:
                    return collider.transform.TransformPoint(capsule.center);
                default:
                    return Vector3.zero;
            }
        }

        public static Vector3 GetActualHalfSize(this BoxCollider box)
        {
            return Vector3.Scale(box.size.Abs() / 2, box.transform.lossyScale.Abs());
        }

        public static float GetMax(this Vector3 value)
        {
            value = value.Abs();
            return Mathf.Max(Mathf.Max(value.x, value.y), value.z);
        }

        private static Vector3 GetStatus(this CapsuleCollider capsule, out float actualRadius, out float actualHeight)
        {
            Vector3 lossyScale = capsule.transform.lossyScale.Abs();
            switch (capsule.direction)
            {
                case 0:
                    actualRadius = capsule.radius * Mathf.Max(lossyScale.y, lossyScale.z);
                    actualHeight = Mathf.Max(actualRadius * 2, capsule.height * lossyScale.x);
                    return Vector3.right;
                case 1:
                    actualRadius = capsule.radius * Mathf.Max(lossyScale.x, lossyScale.z);
                    actualHeight = Mathf.Max(actualRadius * 2, capsule.height * lossyScale.y);
                    return Vector3.forward;
                case 2:
                    actualRadius = capsule.radius * Mathf.Max(lossyScale.x, lossyScale.y);
                    actualHeight = Mathf.Max(actualRadius * 2, capsule.height * lossyScale.z);
                    return Vector3.up;
            }
            actualRadius = actualHeight = 0;
            return Vector3.zero;
        }
    }
}
