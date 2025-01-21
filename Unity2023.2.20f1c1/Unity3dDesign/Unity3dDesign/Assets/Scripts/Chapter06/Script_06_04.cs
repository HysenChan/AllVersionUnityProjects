using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Playables;

[CustomGridBrush(false, true, false, "Custom Brush")]
public class CustomBrush : UnityEditor.Tilemaps.GridBrush
{
    //���л�����
    public string name;
    public override void Paint(GridLayout grid, GameObject brushTarget, Vector3Int position)
    {
        if (EditorUtility.DisplayDialog("��Ҫ��ʾ", string.Format("ȷ�ϱ�ˢ��{0}{1}", grid.name, position), "ok"))
        {
            base.Paint(grid, brushTarget, position);
        }
    }

    //������������
    [MenuItem("Assets/Create/CustomBrush")]
    public static void CreateCustomBrush()
    {
        string path = EditorUtility.SaveFilePanelInProject("Save CustomBrush", "New CustomBrush", "Asset", "Save CustomBrush", "Assets");
        if (path == "")
            return;

        AssetDatabase.CreateAsset(ScriptableObject.CreateInstance<CustomBrush>(), path);
    }
}

[CustomEditor(typeof(CustomBrush))]
public class CustomBrushEditor : UnityEditor.Tilemaps.GridBrushEditor
{
    protected override void OnEnable()
    {
        base.OnEnable();
        //��ȡ���л�����Ϣ
        Debug.Log((target as CustomBrush).name);
    }
    public override void OnPaintSceneGUI(GridLayout gridLayout, GameObject brushTarget, BoundsInt position, GridBrushBase.Tool tool, bool executing)
    {
        base.OnPaintSceneGUI(gridLayout, brushTarget, position, tool, executing);
        //�Զ�����ƻ�������
        Handles.color = Color.red;
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.red;
        style.fontSize = 20;
        Handles.Label(gridLayout.CellToWorld(new Vector3Int(position.x, position.y, 0)), position.center.ToString(), style);
    }
}