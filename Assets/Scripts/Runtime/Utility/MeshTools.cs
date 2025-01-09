using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YKGame.Runtime
{
    public static class MeshTools
    {
        /// <summary>
        /// 生成扇形柱mesh
        /// </summary>
        public static void CreateFanShapeMesh(Mesh mesh, float radius, float angle, float height)
        {
            Vector3 leftdir = Quaternion.AngleAxis(-angle / 2, Vector3.up) * Vector3.forward;
            Vector3 rightdir = Quaternion.AngleAxis(angle / 2, Vector3.up) * Vector3.forward;
            int pcount = Mathf.FloorToInt(angle / 10f);
            //顶点
            Vector3[] vertices = new Vector3[pcount + 3];
            vertices[0] = Vector3.zero;
            vertices[1] = leftdir * radius;
            vertices[vertices.Length - 1] = rightdir * radius;
            for (int i = 1; i <= pcount; i++)
            {
                Vector3 dir = Quaternion.AngleAxis(10f * i, Vector3.up) * leftdir;
                vertices[i + 1] = dir * radius;
            }
            //三角面
            int[] triangles = new int[3 * (1 + pcount)];
            for (int i = 0; i < (1 + pcount); i++)
            {
                triangles[3 * i] = 0;
                triangles[3 * i + 1] = i + 1;
                triangles[3 * i + 2] = i + 2;
            }

            mesh.Clear();
            mesh.vertices = vertices;
            mesh.triangles = triangles;
            mesh.RecalculateNormals();
            AddThickness(mesh, Vector3.up, height);
        }

        /// <summary>
        /// 顶点顺序为顺/逆时针的面增加厚度
        /// </summary>
        public static void AddThickness(Mesh mesh, Vector3 axix, float thick)
        {
            var vertices = mesh.vertices;
            var triangles = mesh.triangles;
            Vector3[] thickVertices = new Vector3[vertices.Length * 2];
            int[] thickTriangles = new int[triangles.Length * 2 + vertices.Length * 2 * 3];
            for (int i = 0; i < vertices.Length; i++)
            {
                thickVertices[i] = vertices[i] + thick / 2 * axix;
                thickVertices[i + vertices.Length] = vertices[i] - thick / 2 * axix;
            }
            for (int i = 0; i < triangles.Length - 2; i++)
            {
                thickTriangles[i] = triangles[i];
                thickTriangles[i + triangles.Length] = triangles[i + 2] + vertices.Length;
                i++;
                thickTriangles[i] = triangles[i];
                thickTriangles[i + triangles.Length] = triangles[i] + vertices.Length;
                i++;
                thickTriangles[i] = triangles[i];
                thickTriangles[i + triangles.Length] = triangles[i - 2] + vertices.Length;
            }
            Vector3 normal = mesh.normals[0];
            Vector3 up = Vector3.Cross(Vector3.ProjectOnPlane(vertices[1] - vertices[0], normal), Vector3.ProjectOnPlane(vertices[2] - vertices[0], normal));
            bool clockwise = Vector3.Project(up, normal).normalized == normal;
            //侧面
            int triangleIndex = triangles.Length / 3 * 2;
            for (int j = 0; j < vertices.Length; j++)
            {
                int p1 = j;
                int p2 = (j + 1) % vertices.Length;
                int p3 = j + vertices.Length;
                int p4 = p2 + vertices.Length;

                if (!clockwise)
                {
                    thickTriangles[3 * triangleIndex] = p1;
                    thickTriangles[3 * triangleIndex + 1] = p2;
                    thickTriangles[3 * triangleIndex + 2] = p3;
                    triangleIndex++;
                    thickTriangles[3 * triangleIndex] = p3;
                    thickTriangles[3 * triangleIndex + 1] = p2;
                    thickTriangles[3 * triangleIndex + 2] = p4;
                    triangleIndex++;
                }
                else
                {
                    thickTriangles[3 * triangleIndex] = p1;
                    thickTriangles[3 * triangleIndex + 1] = p3;
                    thickTriangles[3 * triangleIndex + 2] = p2;
                    triangleIndex++;
                    thickTriangles[3 * triangleIndex] = p2;
                    thickTriangles[3 * triangleIndex + 1] = p3;
                    thickTriangles[3 * triangleIndex + 2] = p4;
                    triangleIndex++;
                }
            }

            mesh.vertices = thickVertices;
            mesh.triangles = thickTriangles;
            mesh.RecalculateNormals();
            mesh.RecalculateBounds();
        }
    }
}
