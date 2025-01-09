using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace YKGame.Runtime
{
    /// <summary>
    /// spine受击变色
    /// </summary>
    public class SpineFillColor : MonoBehaviour
    {
        public static readonly int _FillColor = Shader.PropertyToID("_FillColor");
        public static readonly int _FillPhase = Shader.PropertyToID("_FillPhase");
        public static readonly int _MainTex = Shader.PropertyToID("_MainTex");
        public static Material _material;
        private static MaterialPropertyBlock emptyBlock;

        private MaterialPropertyBlock block;
        private SkeletonRenderer skeletonRenderer;
        private Material originMaterial;
        private MeshRenderer mesh;
        private float runtime;
        private int cycle;

        public Color color;
        public float fromFillPhase;
        public float toFillPhase;
        public float duration;
        public int cycleCount;

        void Awake()
        {
            emptyBlock ??= new MaterialPropertyBlock();
            _material ??= new Material(Shader.Find("Spine/Skeleton Fill"));
            Init();
        }

        public SpineFillColor Init()
        {
            if(block == null)
            {
                block = new MaterialPropertyBlock();
                mesh = GetComponent<MeshRenderer>();
                skeletonRenderer = GetComponent<SkeletonRenderer>();
                skeletonRenderer.OnRebuild += UpdateMainTexture;
                UpdateMainTexture(skeletonRenderer);
            }
            return this;
        }

        private void OnDestroy()
        {
            if(skeletonRenderer != null)
                skeletonRenderer.OnRebuild -= UpdateMainTexture;
        }

        /// <summary>
        /// 设置贴图
        /// </summary>
        private void UpdateMainTexture(SkeletonRenderer skeletonRenderer)
        {
            originMaterial = skeletonRenderer.SkeletonDataAsset.atlasAssets[0].Materials.FirstOrDefault();
            if (originMaterial != null)
                block.SetTexture(_MainTex, originMaterial.mainTexture);
            mesh.SetPropertyBlock(emptyBlock);
        }

        [ContextMenu("Play")]
        private void Play()
        {
            Play(color, fromFillPhase, toFillPhase, duration, cycleCount);
        }

        [ContextMenu("Set Color")]
        private void SetColor()
        {
            SetColor(color, fromFillPhase);
        }

        /// <summary>
        /// 播放动效 颜色填充从startFillPhase变为endFillPhase，耗时duration，播放count次，播放第偶数次时为倒放
        /// </summary>
        /// <param name="color"></param>
        /// <param name="startFillPhase"></param>
        /// <param name="endFillPhase"></param>
        /// <param name="duration"></param>
        /// <param name="count"></param>
        public void Play(Color color, float startFillPhase, float endFillPhase, float duration, int count)
        {
            this.color = color;
            this.duration = duration;
            fromFillPhase = startFillPhase;
            toFillPhase = endFillPhase;
            cycle = count;
            runtime = 0;
            cycleCount = 0;

            skeletonRenderer.CustomMaterialOverride[originMaterial] = _material;
            block.SetColor(_FillColor, color);
            block.SetFloat(_FillPhase, startFillPhase);
            mesh.SetPropertyBlock(block);
            enabled = true;
            skeletonRenderer.LateUpdateMesh();
        }

        /// <summary>
        /// 设置填充色，取消直接禁用脚本
        /// </summary>
        /// <param name="color"></param>
        /// <param name="fillPhase"></param>
        public void SetColor(Color color, float fillPhase)
        {
            Play(color, fillPhase, 0, 0, 0);
        }

        private void OnDisable()
        {
            cycleCount = cycle;
            skeletonRenderer.CustomMaterialOverride.Clear();
            mesh.SetPropertyBlock(emptyBlock);
            enabled = false;
        }

        void Update()
        {
            if (cycleCount >= cycle)
                return;
            runtime += Time.deltaTime;
            if (runtime >= duration)
            {
                int add = (int)(runtime / duration);
                cycleCount += add;
                if(cycleCount >= cycle)
                {
                    enabled = false;
                    return;
                }
                runtime -= duration;
                if(add % 2 != 0)
                {
                    float t = fromFillPhase;
                    fromFillPhase = toFillPhase;
                    toFillPhase = t;
                }
            }
            block.SetFloat(_FillPhase, Mathf.Lerp(fromFillPhase, toFillPhase, runtime / duration));
            mesh.SetPropertyBlock(block);
        }
    }
}
