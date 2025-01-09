using FairyGUI;
using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

namespace YKGame.Runtime
{
    public class PathManager : MonoBehaviour
    {
        public Material material;
        public float lineWidth;

        public bool ispathwin;

        public string configPath;

        public int Count;
        public string nodeName = "btn_lv";
        private LinePath[] paths;
        private UIPanel panel;
        private GGraph graph;
        private static Vector3 offset;
        public static Vector3 Offset => converting ? offset : Vector3.zero;
        private static bool converting;

        private void Awake()
        {
            JsonMapper.RegisterExporter<Vector2>((v, w) => {
                w.Write($"[{v.x},{v.y}]");
            });
            JsonMapper.RegisterImporter<string, Vector2>(input => {
                float[] v = JsonMapper.ToObject<float[]>(input);
                return new Vector2(v[0], v[1]);
            });
            JsonMapper.RegisterExporter<Vector3>((v, w) => {
                w.Write($"[{v.x},{v.y},{v.z}]");
            });
            JsonMapper.RegisterImporter<string, Vector3>(input => {
                float[] v = JsonMapper.ToObject<float[]>(input);
                return new Vector3(v[0], v[1], v[2]);
            });
        }

        void Start()
        {
            panel ??= FindObjectOfType<UIPanel>();
            GComponent mainWindow = panel.ui.asCom;
            if (!ispathwin)
                mainWindow = panel.ui.asCom.GetChild("n0").asCom.GetChild("n6").asCom;
            offset = mainWindow.displayObject.gameObject.transform.position;
            mainWindow.AddChild(graph = new GGraph());
            Stack<GComponent> stack = new Stack<GComponent>();
            stack.Push(mainWindow);

            GameObject nodes = GameObject.Find("Nodes");
            nodes ??= new GameObject("Nodes");
            nodes.transform.parent = transform.parent;
            while (stack.Count > 0)
            {
                var com = stack.Pop();
                foreach (GObject child in com.GetChildren())
                {
                    if (child is GComponent e)
                    {
                        stack.Push(e);
                        if (child.displayObject.gameObject.name == nodeName)
                        {
                            GameObject go = nodes.transform.Find(child.name)?.gameObject;
                            if (go == null)
                            {
                                go = new GameObject(child.name);
                                go.transform.parent = nodes.transform;

                                go.AddComponent<PathSet>();
                            }
                            go.transform.position = child.displayObject.gameObject.transform.position;
                        }
                    }
                }
            }
        }

#if UNITY_EDITOR
        [ContextMenu("µº≥ˆ≈‰÷√")]
        private void ToJson()
        {
            converting = true;

            var jsonWriter = new JsonWriter();
            jsonWriter.PrettyPrint = true;
            jsonWriter.IndentValue = 4;

            LinePath[] paths = FindObjectsOfType<LinePath>();
            Vector3[][] points = new Vector3[paths.Length][];
            for (int i = 0; i < paths.Length; i++)
            {
                points[i] = paths[i].GetPath();
            }

            PathSet[] pathSets = FindObjectsOfType<PathSet>();
            NodeLink[] nodes = new NodeLink[pathSets.Length];
            for (int i = 0; i < pathSets.Length; i++)
            {
                nodes[i] = new NodeLink();
                nodes[i].nodeName = pathSets[i].name;
                LinePath[] ls = pathSets[i].previousPaths;
                nodes[i].previousPath = new int[ls.Length];
                for (int j = 0; j < ls.Length; j++)
                {
                    nodes[i].previousPath[j] = Array.IndexOf(paths, ls[j]);
                }
                ls = pathSets[i].nextPaths;
                nodes[i].nextPath = new int[ls.Length];
                for (int j = 0; j < ls.Length; j++)
                {
                    nodes[i].nextPath[j] = Array.IndexOf(paths, ls[j]);
                }
            }

            JsonMapper.ToJson((Paths: points, Nodes: nodes), jsonWriter);
            using (StreamWriter sw = new StreamWriter(configPath))
            {
                sw.Write(jsonWriter.ToString());
            }

            converting = false;
        }
#endif

        IEnumerator Destroy(GameObject gameObject)
        {
            yield return 1;
            DestroyImmediate(gameObject);
        }

        private void OnValidate()
        {
            paths = GetComponentsInChildren<LinePath>();
            if (Count < paths.Length)
            {
                for (int i = paths.Length - 1, loop = paths.Length - Count; loop > 0; i--, loop--)
                {
                    StartCoroutine(Destroy(paths[i].gameObject));
                }
            }
            else if (Count > paths.Length)
            {
                int loop = Count - paths.Length;
                while (loop-- > 0)
                {
                    LinePath path = new GameObject().AddComponent<LinePath>();
                    path.transform.parent = transform;
                }
            }
            else
                return;
            paths = GetComponentsInChildren<LinePath>();
            for (int i = 0; i < paths.Length; i++)
            {
                paths[i].name = $"path({i})";
            }
        }
    }
}