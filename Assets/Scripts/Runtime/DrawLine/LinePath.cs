using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YKGame.Runtime
{
    [ExecuteInEditMode]
    public class LinePath : MonoBehaviour
    {
        public int Count;
        private Corner[] corners;
        LineRenderer lineRenderer = null;

        IEnumerator Destroy(GameObject gameObject)
        {
            yield return 1;
            DestroyImmediate(gameObject);
        }

        private void OnValidate()
        {
            corners = GetComponentsInChildren<Corner>();
            if (Count < corners.Length)
            {
                for (int i = corners.Length - 1, loop = corners.Length - Count; loop > 0; i--, loop--)
                {
                    StartCoroutine(Destroy(corners[i].gameObject));
                }
            }
            else if (Count > corners.Length)
            {
                int loop = Count - corners.Length;
                while (loop-- > 0)
                {
                    Corner corner = GameObject.CreatePrimitive(PrimitiveType.Sphere).AddComponent<Corner>();
                    corner.transform.parent = transform;
                    corner.transform.localScale = Vector3.one * 0.2f;
                }
            }
            else
                return;
            corners = GetComponentsInChildren<Corner>();
            for (int i = 0; i < corners.Length; i++)
            {
                corners[i].name = $"corner({i})";
            }
        }

        private Vector3 this[int index]
        {
            get
            {
                return corners[index].transform.position - PathManager.Offset;
            }
        }

        public Vector3[] GetPath()
        {
            corners = GetComponentsInChildren<Corner>();
            if (corners.Length == 0)
                return null;

            List<Vector3> posList = new List<Vector3>();

            posList.Add(this[0]);

            for (int i = 1; i < corners.Length - 1; i++)
            {
                Corner corner = corners[i];
                if (corner.count <= 0 || corner.radius <= 0)
                {
                    posList.Add(this[i]);
                    continue;
                }
                Vector3 from = this[i - 1] - this[i];
                Vector3 to = this[i + 1] - this[i];
                float angle = Vector3.SignedAngle(from, to, Vector3.Cross(from, to));
                float tanHalfAngle = Mathf.Tan(Mathf.Abs(angle / 2) * Mathf.Deg2Rad);
                float maxRadius = tanHalfAngle * Mathf.Min(from.magnitude, to.magnitude);
                float radius = Mathf.Clamp(corner.radius, 0, maxRadius);
                Vector3 center = Quaternion.AngleAxis(angle / 2f, Vector3.Cross(from, to)) * from.normalized * radius / Mathf.Sin(Mathf.Abs(angle / 2) * Mathf.Deg2Rad) + this[i];
                Vector3 firstPoint = from.normalized * radius / tanHalfAngle + this[i];
                Vector3 endPoint = to.normalized * radius / tanHalfAngle + this[i];
                posList.Add(firstPoint);
                angle = (angle > 0 ? 180 : -180) - angle;
                angle /= corner.count + 1;
                for (int j = 1; j < corner.count + 1; j++)
                {
                    posList.Add(Quaternion.AngleAxis(angle * j, Vector3.Cross(firstPoint - center, endPoint - center)) * (firstPoint - center) + center);
                }
                posList.Add(endPoint);
            }

            posList.Add(this[corners.Length - 1]);

            return posList.ToArray();
        }

        private void OnEnable()
        {
            lineRenderer = gameObject.GetComponent<LineRenderer>();
            if(lineRenderer == null)
                lineRenderer = gameObject.AddComponent<LineRenderer>();
            var path = FindObjectOfType<PathManager>();
            lineRenderer.material = path.material;
            lineRenderer.startWidth = lineRenderer.endWidth = path.lineWidth;
            lineRenderer.textureMode = LineTextureMode.Tile;
            lineRenderer.useWorldSpace = false;
        }

        private void Update()
        {
            lineRenderer = gameObject.GetComponent<LineRenderer>();
            Vector3[] path = GetPath();
            if (path != null)
            {
                lineRenderer.positionCount = path.Length;
                lineRenderer.SetPositions(path);
            }
        }
    }
}
