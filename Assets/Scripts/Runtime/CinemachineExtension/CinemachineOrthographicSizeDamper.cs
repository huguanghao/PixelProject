using UnityEngine;

namespace Cinemachine
{
    public class CinemachineOrthographicSizeDamper : CinemachineExtension
    {
        /// <summary>
        /// 目标值
        /// </summary>
        public float orthographicSize;
        [Range(0, 10)]
        public float m_Damping = 0;
        public float m_Min = 1;
        public float m_Max = 10;

        protected override void Awake()
        {
            base.Awake();
            (VirtualCamera as CinemachineVirtualCamera).m_Lens.OrthographicSize = orthographicSize;
        }

        protected override void ConnectToVcam(bool connect)
        {
            base.ConnectToVcam(connect);
            //确保CinemachineConfiner在自己后面执行
            CinemachineConfiner confiner = GetComponent<CinemachineConfiner>();
            if (confiner != null)
                VirtualCamera.AddExtension(confiner);
        }

        class VcamExtraState
        {
            public float m_previousSize;
        };

        protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
        {
            VcamExtraState extra = GetExtraState<VcamExtraState>(vcam);
            if (deltaTime < 0 || !VirtualCamera.PreviousStateIsValid)
                extra.m_previousSize = state.Lens.OrthographicSize;
            if (stage == CinemachineCore.Stage.Body)
            {
                LensSettings lens = state.Lens;
                orthographicSize = Mathf.Clamp(orthographicSize, m_Min, m_Max);
                if (deltaTime >= 0 && VirtualCamera.PreviousStateIsValid)
                {
                    //extra.m_previousSize += Damper.Damp(orthographicSize - extra.m_previousSize, m_Damping, deltaTime);
                    extra.m_previousSize += VirtualCamera.DetachedLookAtTargetDamp(orthographicSize - extra.m_previousSize, m_Damping, deltaTime);
                }
                lens.OrthographicSize = extra.m_previousSize = Mathf.Clamp(extra.m_previousSize, m_Min, m_Max);
                state.Lens = lens;
                (vcam as CinemachineVirtualCamera).m_Lens = lens;
            }
        }
    }
}
