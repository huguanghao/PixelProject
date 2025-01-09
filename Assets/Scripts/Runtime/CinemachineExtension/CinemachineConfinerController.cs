using UnityEngine;

namespace Cinemachine
{
    public class CinemachineConfinerController : CinemachineExtension
    {
        class VcamExtraState
        {
            public bool m_previousOrthographic;
            public float m_previousHeight;
            public float m_previousAngle;
            public float m_previousFov;
            public float m_previousAspect;
        };

        public BoxCollider m_BoundingVolume;
        private MapSetting map;
        /// <summary>
        /// Tan(cameraAngle - halfFOV)
        /// </summary>
        private float coefficient_1;
        /// <summary>
        /// Tan(cameraAngle + halfFOV)
        /// </summary>
        private float coefficient_2;
        /// <summary>
        /// Camera.main.aspect * Sin(halfFOV) / Sin(cameraAngle + halfFOV)
        /// </summary>
        private float coefficient_3;

        public Vector3 center;
        public Vector3 size;
        private bool isValidated;

        public void Init(MapSetting newMap)
        {
#if UNITY_EDITOR
            if (map != null)
                map.onValidated -= OnMapValidate;
            newMap.onValidated += OnMapValidate;
#endif
            map = newMap;
            m_BoundingVolume.transform.position = new Vector3(map.Size.x / 2f, 0, map.Size.y / 2f) + map.StartWorldPosition;
            isValidated = true;
        }

#if UNITY_EDITOR
        private void OnMapValidate()
        {
            isValidated = true;
        }
#endif
        protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
        {
            if (map == null)
                return;
            //地图配置发生变化
            if (isValidated)
            {
                center.x = (map.Edge_Dis_Right - map.Edge_Dis_Left) / 2;
                center.z = (map.Edge_Dis_Up - map.Edge_Dis_Down) / 2;
                size.x = map.SizeWithEdge.x;
                size.z = map.SizeWithEdge.y;
            }
            center.y = state.FinalPosition.y;
            //正交相机
            if (state.Lens.Orthographic)
            {
                m_BoundingVolume.center = center;
                m_BoundingVolume.size = size;
                isValidated = false;
                return;
            }
            //透视
            VcamExtraState extra = GetExtraState<VcamExtraState>(vcam);
            if (isValidated || extra.m_previousOrthographic)
            {
                OnFovChanged(state.Lens.FieldOfView, transform.localEulerAngles.x, state.Lens.Aspect);
                UpdateBounds();
            }
            else
            {
                if (extra.m_previousFov != state.Lens.FieldOfView 
                    || extra.m_previousAngle != transform.localEulerAngles.x 
                    || extra.m_previousAspect != state.Lens.Aspect)
                {
                    OnFovChanged(state.Lens.FieldOfView, transform.localEulerAngles.x, state.Lens.Aspect);
                    UpdateBounds();
                }
                else if (extra.m_previousHeight != state.FinalPosition.y)
                {
                    UpdateBounds();
                }
            }
            isValidated = false;
            extra.m_previousOrthographic = state.Lens.Orthographic;
            extra.m_previousHeight = state.FinalPosition.y;
            extra.m_previousFov = state.Lens.FieldOfView;
            extra.m_previousAspect = state.Lens.Aspect;
            extra.m_previousAngle = transform.localEulerAngles.x;
        }

        private void OnFovChanged(float fieldOfView, float angle, float aspect)
        {
            float halfFOV = fieldOfView / 2 * Mathf.Deg2Rad;
            float cameraAngle = angle * Mathf.Deg2Rad;
            coefficient_1 = Mathf.Tan(cameraAngle - halfFOV);
            coefficient_2 = Mathf.Tan(cameraAngle + halfFOV);
            float temp = Mathf.Sin(cameraAngle + halfFOV);
            coefficient_3 = temp == 0 ? 0 : aspect * Mathf.Sin(halfFOV) / temp;
        }

        public void UpdateBounds()
        {
            float height = center.y;
            float rect_offset_up = map.ignoreUp || coefficient_1 == 0 ? 0 : height / coefficient_1;
            float rect_offset_down = coefficient_2 == 0 ? 0 : height / coefficient_2;
            float rect_offset_left_or_right = height * coefficient_3;

            m_BoundingVolume.center = center + Vector3.forward * (-rect_offset_down - rect_offset_up) / 2;
            m_BoundingVolume.size = size + new Vector3(-2 * rect_offset_left_or_right, 0, rect_offset_down - rect_offset_up);
        }
    }
}
