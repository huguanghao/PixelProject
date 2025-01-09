#if !(UNITY_STANDALONE_WIN || UNITY_STANDALONE_LINUX || UNITY_STANDALONE_OSX || STEAMWORKS_WIN || STEAMWORKS_LIN_OSX)
#define DISABLESTEAMWORKS
#endif

#if !DISABLESTEAMWORKS

using JEngine.Core;
using Steamworks;
using UnityEngine;

namespace YKGame.Runtime {
    public class SteamSDK : MonoBehaviour {
        public bool m_IsOpenSteamSDK = false;
        public int m_SteamAppID = 2934470;
        public int m_SteamChannelID = 9999;
        public bool m_IsSandboxTest = false;
        public string m_SteamName;
        public ulong m_SteamID;
        public string m_Language = "english";

        private static SteamSDK instance;

        private static bool isInitialized = false;

        public static SteamSDK Instance { get { return instance; } }

        public static bool IsInitialized { get { return isInitialized; } }

        public bool IsOpenSteamSDK {
            get {
                return m_IsOpenSteamSDK;
            }
        }

        public int SteamAppID {
            get {
                return m_SteamAppID;
            }
        }


        public int SteamChannelID {
            get {
                return m_SteamChannelID;
            }
        }

        public ulong SteamID {
            get {
                return m_SteamID;
            }
        }

        public string Language
        {
            get
            {
                return m_Language;
            }
        }

        protected Callback<MicroTxnAuthorizationResponse_t> m_SteamPayCall;

        private Callback<GameOverlayActivated_t> m_GameOverlayActivated;

        protected void Awake() {
            if (!m_IsOpenSteamSDK) {
                return;
            }
           
            DontDestroyOnLoad(gameObject);
            instance = this;

            if (SteamManager.Initialized) {
                isInitialized = true;
                // ��ǰsteam��½���û�����
                m_SteamName = SteamFriends.GetPersonaName();
                Log.PrintWarning($"��ǰ��¼Steam�û�����: {m_SteamName}");
                m_SteamID = SteamUser.GetSteamID().m_SteamID;
                Log.PrintWarning($"��ǰ��¼Steam�û�Id: {m_SteamID}");

                m_Language = SteamApps.GetCurrentGameLanguage();

                // ע��steam֧���ص�
                m_SteamPayCall = Callback<MicroTxnAuthorizationResponse_t>.Create(OnMicroTxnAuthorizationResponse);

                // ע��Steam���漤��ص�
                m_GameOverlayActivated = Callback<GameOverlayActivated_t>.Create(GameOverlayActivated_t);
            }
        }

        /// <summary>
        /// Steam���漤��ص�
        /// </summary>
        /// <param name="pCallback"></param>
        private void GameOverlayActivated_t(GameOverlayActivated_t pCallback) {
            Debug.Log($"Steam���漤��... {pCallback.m_bActive}");
        }

        /// <summary>
        /// Steam֧���ص�
        /// </summary>
        /// <param name="pCallback"></param>
        private void OnMicroTxnAuthorizationResponse(MicroTxnAuthorizationResponse_t pCallback) {
            Debug.Log("Steam֧���ɹ��ص�...");
        }
    }
}

#endif // !DISABLESTEAMWORKS