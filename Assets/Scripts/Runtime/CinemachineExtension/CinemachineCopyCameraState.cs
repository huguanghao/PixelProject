using UnityEngine;

namespace Cinemachine
{
    public class CinemachineCopyCameraState : MonoBehaviour
    {
        [Tooltip("将目标虚拟相机状态复制给我")]
        public Camera m_Camera;
        [Tooltip("目标虚拟相机")]
        public CinemachineBrain brain;

        private void OnEnable()
        {
            CinemachineCore.CameraUpdatedEvent.AddListener(OnUpdate);
        }

        private void OnDisable()
        {
            CinemachineCore.CameraUpdatedEvent.RemoveListener(OnUpdate);
        }

        private void OnUpdate(CinemachineBrain arg0)
        {
            if (brain == null || arg0 == brain)
            {
                PushStateToUnityCamera();
            }
        }

        private void PushStateToUnityCamera()
        {
            CameraState state = brain.CurrentCameraState;
            if ((state.BlendHint & CameraState.BlendHintValue.NoPosition) == 0)
            {
                transform.position = state.FinalPosition;
            }

            if ((state.BlendHint & CameraState.BlendHintValue.NoOrientation) == 0)
            {
                transform.rotation = state.FinalOrientation;
            }

            if ((state.BlendHint & CameraState.BlendHintValue.NoLens) == 0)
            {
                if (m_Camera != null)
                {
                    m_Camera.nearClipPlane = state.Lens.NearClipPlane;
                    m_Camera.farClipPlane = state.Lens.FarClipPlane;
                    m_Camera.fieldOfView = state.Lens.FieldOfView;
                    m_Camera.orthographic = state.Lens.Orthographic;
                    if (m_Camera.orthographic)
                    {
                        m_Camera.orthographicSize = state.Lens.OrthographicSize;
                    }
                    else
                    {
                        m_Camera.usePhysicalProperties = state.Lens.IsPhysicalCamera;
                        m_Camera.lensShift = state.Lens.LensShift;
                    }
                }
            }
        }
    }
}
