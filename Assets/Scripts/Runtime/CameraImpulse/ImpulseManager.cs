using Cinemachine;
using System.Collections;
using UnityEngine;

namespace YKGame.Runtime
{
    [RequireComponent(typeof(CinemachineImpulseSource))]
    public class ImpulseManager : MonoBehaviour
    {
        private static ImpulseManager _inst;
        public static ImpulseManager Instance
        {
            get
            {
                if (_inst == null)
                {
                    _inst = new GameObject("ImpulseManager").AddComponent<ImpulseManager>();
                    GameObject.DontDestroyOnLoad(_inst);
                }
                return _inst;
            }
        }

        private CinemachineImpulseSource impulseSource;
        private float lastImpulseEndTime;
        private ImpulseSetting playingImpulse;
        private int curNoiseIndex;

# if UNITY_EDITOR
        public ImpulseSetting previewSetting;
        public bool preview;

        private void OnValidate()
        {
            if (preview)
            {
                preview = false;
                Shake(previewSetting, true);
            }
        }
#endif

        private void Awake()
        {
            impulseSource = gameObject.GetComponent<CinemachineImpulseSource>();
        }

        public void Shake(ImpulseSetting setting, bool force = false, float gain = 1f)
        {
            if (force)
            {
                StopAllCoroutines();
                CinemachineImpulseManager.Instance.Clear();
            }
            else if (CinemachineImpulseManager.Instance.CurrentTime < lastImpulseEndTime)
                return;
            impulseSource.m_ImpulseDefinition.m_FrequencyGain = gain;
            impulseSource.m_ImpulseDefinition.m_RawSignal = setting.noises[0].rawSignal;
            impulseSource.m_ImpulseDefinition.m_TimeEnvelope.m_AttackShape = setting.attackCurve;
            impulseSource.m_ImpulseDefinition.m_TimeEnvelope.m_AttackTime = setting.attackTime;
            impulseSource.m_ImpulseDefinition.m_TimeEnvelope.m_SustainTime = setting.sustainTime;
            impulseSource.m_ImpulseDefinition.m_TimeEnvelope.m_DecayShape = setting.decayCurve;
            impulseSource.m_ImpulseDefinition.m_TimeEnvelope.m_DecayTime = setting.decayTime;
            Vector3 velocity;
            if (Camera.main == null)
                velocity = transform.forward;
            else
                velocity = Camera.main.transform.forward;
            velocity *= setting.force;
            impulseSource.GenerateImpulse(velocity);
            lastImpulseEndTime = CinemachineImpulseManager.Instance.CurrentTime + setting.TotalTime;

            playingImpulse = setting;
            curNoiseIndex = 0;
            if (++curNoiseIndex < setting.noises.Length)
                StartCoroutine(WaitToPlayNext());
        }

        private IEnumerator WaitToPlayNext()
        {
            yield return new WaitForSeconds(playingImpulse.noises[curNoiseIndex].timePoint);
            impulseSource.m_ImpulseDefinition.m_RawSignal = playingImpulse.noises[curNoiseIndex].rawSignal;
            if (++curNoiseIndex < playingImpulse.noises.Length)
            {
                StartCoroutine(WaitToPlayNext());
            }
        }
    }
}
