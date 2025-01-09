using UnityEngine;
using UnityEditor;
using YKGame.Runtime;
using static GluonGui.WorkspaceWindow.Views.WorkspaceExplorer.Configuration.ConfigurationTreeNodeCheck;

[CustomEditor(typeof(MapSetting))]
public class MapSettingInspector : Editor
{
    MapSetting mapSetting;

    private void OnEnable()
    {
        if (mapSetting == null)
        {
            mapSetting = (MapSetting)target;
        }
    }

    public override void OnInspectorGUI()
	{
        base.OnInspectorGUI();

        if (GUILayout.Button("Auto Set Start Pos"))
		{
            mapSetting.AutoSetStartPos();
		}
    }
}
