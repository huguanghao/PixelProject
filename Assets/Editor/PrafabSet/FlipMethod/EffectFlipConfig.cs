using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using UnityEditor.SceneManagement;
using YKGame.Runtime;

public class EffectFlipConfig : EditorWindow
{

    [MenuItem("Game/GameObjectFlipConfig")]
    public static void ShowExample()
    {
        if (!Application.isPlaying)
        {
            EffectFlipConfig wnd = GetWindowWithRect<EffectFlipConfig>(new Rect(100f, 100f, 800f, 600f), true, "�����������ҷ�ת��ʽ", true);
            wnd.Show();
            //wnd?.Close();
            //wnd.minSize = new Vector2(800, 600);
        }
    }

    private GameObject previewPrefab;
    private string effectPath;
    private FlipMethodType group;
    private List<string> assets;
    private ListView effectList;
    private PopupField<FlipMethodType> listGroup;
    private bool autoSave;

    private FlipConfig configSetter = new FlipConfig();
    private PopupField<FlipMethodType> flipMethodType;

    public void CreateGUI()
    {
        EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);

        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/PrafabSet/FlipMethod/EffectFlipConfig.uxml");
        visualTree.CloneTree(root);

        var effectPathField = root.Q<TextField>("EffectPath");
        effectPathField.RegisterValueChangedCallback(OnAssetPathChanged);
        effectPath = effectPathField.text;
        UpdateItemSource();

        listGroup = new PopupField<FlipMethodType>();
        root.Q<VisualElement>("ListGroup").Add(listGroup);
        listGroup.formatListItemCallback = GetGroupName;
        listGroup.formatSelectedValueCallback = GetGroupName;
        listGroup.RegisterValueChangedCallback(OnGroupChanged);
        listGroup.choices = new List<FlipMethodType>((FlipMethodType[])Enum.GetValues(typeof(FlipMethodType)));

        flipMethodType = new PopupField<FlipMethodType>();
        root.Q<VisualElement>("FlipMethodType").Add(flipMethodType);
        flipMethodType.formatListItemCallback = GetGroupName;
        flipMethodType.formatSelectedValueCallback = GetGroupName;
        flipMethodType.RegisterValueChangedCallback(OnSetFlipMethodType);
        flipMethodType.choices = new List<FlipMethodType>((FlipMethodType[])Enum.GetValues(typeof(FlipMethodType)));

        effectList = root.Q<ListView>("EffectList");
        effectList.makeItem = MakeItem;
        effectList.bindItem = BindItem;
        effectList.itemsSource = assets;
        effectList.onSelectionChange += OnChoiseItem;
        effectList.Rebuild();

        root.Q<Button>("SaveBtn").clicked += Save;
        var toggle = root.Q<Toggle>("AutoSave");
        toggle.RegisterCallback<ChangeEvent<bool>>(AutoSave);
        autoSave = toggle.value;
    }

    private void AutoSave(ChangeEvent<bool> evt)
    {
        autoSave = evt.newValue;
    }

    private void Save()
    {
        SingletonScriptableObject<FlipMethodConfigData>.Save();
    }

    private void OnChoiseItem(IEnumerable<object> selection)
    {
        string asset = (string)selection?.FirstOrDefault();
        if (previewPrefab != null)
            DestroyImmediate(previewPrefab);
        previewPrefab = Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>(asset));

        ReadConfig(asset);
    }

    private void ReadConfig(string asset)
    {
        var cfg = SingletonScriptableObject<FlipMethodConfigData>.Instance.Config[asset];
        Copy(cfg, configSetter);
        flipMethodType.SetValueWithoutNotify(configSetter.type);

        PreviewFlip();
    }

    private void Copy(FlipConfig source, FlipConfig to)
    {
        to.assetPath = source.assetPath;
        to.type = source.type;
    }

    private string GetGroupName(FlipMethodType group)
    {
        return group switch
        {
            FlipMethodType.None => "δ����",
            FlipMethodType.FlipByRotate => "ͨ����ת",
            FlipMethodType.FlipByScaleX => "ͨ������x��",
        };
    }

    private void OnDestroy()
    {
        var effectPathField = rootVisualElement?.Q<TextField>("EffectPath");
        effectPathField?.UnregisterValueChangedCallback(OnAssetPathChanged);
        listGroup?.UnregisterValueChangedCallback(OnGroupChanged);
        flipMethodType?.UnregisterValueChangedCallback(OnSetFlipMethodType);
        rootVisualElement.Q<Button>("SaveBtn").clicked -= Save;
        rootVisualElement.Q<Toggle>("AutoSave").UnregisterCallback<ChangeEvent<bool>>(AutoSave);
        SingletonScriptableObject<FlipMethodConfigData>.Reload();
    }

    private void UpdateItemSource()
    {
        string fullPath = $"{Application.dataPath}{effectPath.Substring("Assets".Length)}";
        if (Directory.Exists(fullPath))
        {
            var allAssets = Directory.GetFiles(fullPath, "*.prefab").Select(o => $"{effectPath}/{Path.GetFileName(o)}");
            assets ??= new List<string>();
            assets.Clear();
            var config = SingletonScriptableObject<FlipMethodConfigData>.Instance;
            config.RemoveInvalid();
            foreach ( var asset in allAssets)
            {
                var cfg = config.GetOrCreate(asset);
                if (cfg.type == group)
                    assets.Add(asset);
            }
        }
    }

    private void OnGroupChanged(ChangeEvent<FlipMethodType> evt)
    {
        group = evt.newValue;
        UpdateItemSource();
        effectList.Rebuild();
    }

    private void OnSetFlipMethodType(ChangeEvent<FlipMethodType> evt)
    {
        int index = effectList.selectedIndex;
        if (index == -1)
            Debug.LogError("���ȴӴ�������б���ѡ��һ������");
        configSetter.type = flipMethodType.value;
        PreviewFlip();
        SetConfig();
    }

    private void PreviewFlip()
    {
        if (previewPrefab != null)
        {
            Vector3 scale = previewPrefab.transform.localScale;
            previewPrefab.transform.eulerAngles = Vector3.zero;
            previewPrefab.transform.position = Vector3.zero;
            switch (flipMethodType.value)
            {
                case FlipMethodType.None:
                    scale.x = Mathf.Abs(scale.x);
                    break;
                case FlipMethodType.FlipByRotate:
                    scale.x = Mathf.Abs(scale.x);
                    previewPrefab.transform.Rotate(Vector3.forward, 180);
                    break;
                case FlipMethodType.FlipByScaleX:
                    scale.x = -Mathf.Abs(scale.x);
                    break;
            }
            previewPrefab.transform.localScale = scale;
        }
    }

    private void SetConfig()
    {
        string asset = configSetter.assetPath;
        if (string.IsNullOrEmpty(asset))
            return;
        var config = SingletonScriptableObject<FlipMethodConfigData>.Instance.Config[asset];
        Copy(configSetter, config);
        if (autoSave)
            Save();
    }

    private void OnAssetPathChanged(ChangeEvent<string> evt)
    {
        effectPath = evt.newValue;
        UpdateItemSource();
        effectList.Rebuild();
    }

    public ObjectField MakeItem()
    {
        return new ObjectField();
    }

    public void BindItem(VisualElement item, int index)
    {
        var child = item as ObjectField;
        child.value = AssetDatabase.LoadAssetAtPath<GameObject>(assets[index]);
    }
}