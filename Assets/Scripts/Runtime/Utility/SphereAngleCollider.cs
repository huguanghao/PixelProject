using System;
using System.Collections.Generic;
using UnityEngine;
using YKGameFramework;

namespace YKGame.Runtime
{
    /// <summary>
    /// ÉÈÐÎÅö×²¼ì²â
    /// </summary>
    public class SphereAngleCollider : MonoBehaviour
    {
        [SerializeField][Range(0f, 360f)] private float angle = 90f;
        [SerializeField] private float radius = 5f;
        public Vector3 rotation;
        //[SerializeField] private float height = 1f;
        //[SerializeField] private LayerMask layerMask;
        private int layer;

        private void OnValidate()
        {
            //layer = layerMask.value;
            Radius = radius;
            //Height = height;
        }

        public float Angle
        {
            set { this.angle = Mathf.Clamp(value, 0, 360f); }
            get { return this.angle; }
        }

        public float Radius
        {
            set { this.radius = Mathf.Max(value, 0); }
            get { return this.radius; }
        }

        //public float Height
        //{
        //    set { this.height = value; }
        //}

        public int Layer
        {
            set { this.layer = value; }
        }

        [NonSerialized] public List<Collider> hitTargets;
        public Action<Collider> onEnter;
        public Action<Collider> onStay;
        public Action<Collider> onExit;

        void Awake()
        {
            hitTargets = new List<Collider>();
            //MaterialPropertyBlock block = new MaterialPropertyBlock();
            //onEnter = collider =>
            //{
            //    var meshRenderer = collider.GetComponent<MeshRenderer>();
            //    meshRenderer.GetPropertyBlock(block);
            //    block.SetColor("_BaseColor", Color.red);
            //    meshRenderer.SetPropertyBlock(block);
            //};
            //onExit = collider =>
            //{
            //    var meshRenderer = collider.GetComponent<MeshRenderer>();
            //    meshRenderer.GetPropertyBlock(block);
            //    block.SetColor("_BaseColor", Color.white);
            //    meshRenderer.SetPropertyBlock(block);
            //};
        }

        private void OnDisable()
        {
            for (int i = 0; i < hitTargets.Count; i++)
            {
                onExit?.Invoke(hitTargets[i]);
            }
            hitTargets.Clear();
        }

        public void GetRotate(out Vector3 forward, out Vector3 up)
        {
            Vector3 rotation = this.rotation;
            if (transform.lossyScale.x < 0)
            {
                rotation.y = -rotation.y;
                rotation.z = -rotation.z;
            }
            if (transform.lossyScale.y < 0)
            {
                rotation.x = -rotation.x;
                rotation.z = -rotation.z;
            }
            if (transform.lossyScale.z < 0)
            {
                rotation.x = -rotation.x;
                rotation.y = -rotation.y;
            }
            forward = Quaternion.AngleAxis(rotation.x, transform.right) * transform.forward;
            forward = Quaternion.AngleAxis(rotation.y, transform.up) * forward;
            up = Quaternion.AngleAxis(rotation.x, transform.right) * transform.up;
            up = Quaternion.AngleAxis(rotation.z, transform.forward) * up;
        }

        private void FixedUpdate()
        {
            lastHits.Clear();
            lastHits.AddRange(hitTargets);
            GetRotate(out Vector3 forward, out Vector3 up);
            PhysicsTools.SphereAngleCastNonAlloc(transform.position, up, forward, angle, radius * transform.lossyScale.x, hitTargets, layer);
            for (int i = 0; i < hitTargets.Count; i++)
            {
                if (!lastHits.Contains(hitTargets[i]))
                    onEnter?.Invoke(hitTargets[i]);
                else
                    onStay?.Invoke(hitTargets[i]);
            }
            for (int i = 0; i < lastHits.Count; i++)
            {
                if (!hitTargets.Contains(lastHits[i]))
                    onExit?.Invoke(lastHits[i]);
            }
        }

#if UNITY_EDITOR
        private Mesh sectorMesh;
        public bool debug = true;
        private void OnDrawGizmosSelected()
        {
            if (!debug)
                return;
            Gizmos.color = Color.green;
            if (sectorMesh == null)
                sectorMesh = new Mesh();
            MeshTools.CreateFanShapeMesh(sectorMesh, Mathf.Abs(radius * transform.lossyScale.x), angle, 0);
            GetRotate(out Vector3 forward, out Vector3 up);
            Gizmos.DrawWireMesh(sectorMesh, -1, transform.position, Quaternion.LookRotation(forward, up), new Vector3(1, 1, 1));
        }
#endif

        private static List<Collider> lastHits;

        static SphereAngleCollider()
        {
            lastHits = new List<Collider>();
        }
    }
}
