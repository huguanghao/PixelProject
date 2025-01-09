using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using System;

namespace YKGame.Editor
{
    public class SkillEditorWindow : EditorWindow
    {
        private SkillTriggerType triggerType;
        private SkillTargetType targetType;

        private VisualElement basicProp;
        private EnumField triggerField;
        private EnumField targetField;

        [MenuItem("Tools/自定义工具/技能编辑器")]
        public static void ShowExample()
        {
            SkillEditorWindow wnd = GetWindow<SkillEditorWindow>();
            wnd.titleContent = new GUIContent("SkillEditorWindow");
        }

        public void CreateGUI()
        {
            // Each editor window contains a root VisualElement object
            VisualElement root = rootVisualElement;

            // Import UXML
            var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/SkillEditor/SkillEditorWindow.uxml");
            visualTree.CloneTree(root);

            //
            basicProp = root.Q<VisualElement>("BasicProp");
            HelpBox helpinfo = new HelpBox("这里的文字描述只是方便策划查看，正式的描述信息需要另外配置text文件，以便多语言支持！", HelpBoxMessageType.Warning);
            basicProp.Add(helpinfo);

            // 触发类型
            triggerType = SkillTriggerType.Auto;
            triggerField = root.Q<EnumField>("SkillTirggerType");
            triggerField.Init(triggerType);
            triggerField.RegisterCallback<ChangeEvent<Enum>>((evt) =>
            {
                triggerType = (SkillTriggerType)Enum.Parse(typeof(SkillTriggerType), evt.newValue.ToString(), true);
                Debug.LogWarning("SkillTriggerType Change string:" + triggerType.ToString() + " || SkillTriggerType:" + (byte)triggerType);
            });

            // 目标类型
            targetType = SkillTargetType.Self;
            targetField = root.Q<EnumField>("SkillTargetType");
            targetField.Init(targetType);
            targetField.RegisterCallback<ChangeEvent<Enum>>((evt) =>
            {
                targetType = (SkillTargetType)Enum.Parse(typeof(SkillTargetType), evt.newValue.ToString(), true);
                Debug.LogWarning("SkillTargetType Change string:" + targetType.ToString() + " || SkillTargetType:" + (byte)targetType);
            });
        }
    }
}