using UnityEngine;
using UnityEditor;
using YKGame.Runtime;
using Cinemachine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Linq;

[CustomEditor(typeof(ImpulseController))]
public class ImpulseControllerInspector : Editor
{
    ImpulseController impulseController;

    private void OnEnable()
    {
        if (impulseController == null)
        {
            impulseController = (ImpulseController)target;
        }
    }

    public override void OnInspectorGUI()
	{
        base.OnInspectorGUI();

        if (GUILayout.Button("添加预览相机"))
		{
            if (!Application.isPlaying)
            {
                Debug.LogError("添加预览相机需要先运行场景！！！");
                return;
            }

            Scene dontDestroyScene = ImpulseManager.Instance.gameObject.scene;
            foreach(GameObject go in dontDestroyScene.GetRootGameObjects())
            {
                if (go.name == "GameSceneObject")
                    return;
            }
            //禁用原场景相机
            Camera.main?.gameObject.SetActive(false);
            //加载游戏场景相机
            SceneManager.LoadScene("Assets/HotUpdateResources/Main/Scene/Map/Game.unity", LoadSceneMode.Additive);
            SceneManager.sceneLoaded += OnLoadSuccess;
        }
    }

    private void OnLoadSuccess(Scene scene,LoadSceneMode loadSceneMode)
    {
        GameObject go = scene.GetRootGameObjects()[0];
        CinemachineBrain brain = go.transform.GetComponentInChildren<CinemachineBrain>();
        brain.OutputCamera.orthographic = true;
        CinemachineVirtualCamera virtualCamera = go.transform.Find("CM vcam1").GetComponent<CinemachineVirtualCamera>();
        virtualCamera.m_Lens.OrthographicSize = 10;
        virtualCamera.Follow = impulseController.gameObject.transform;
        virtualCamera.transform.eulerAngles = new Vector3(85, 0, 0);
        var framingTransposer = virtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>();
        framingTransposer.m_CameraDistance = 10;

        GameObject.DontDestroyOnLoad(go);
        SceneManager.UnloadSceneAsync(scene);

        SceneManager.sceneLoaded -= OnLoadSuccess;
    }
}
