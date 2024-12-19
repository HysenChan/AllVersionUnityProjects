using UnityEngine;
using UnityEditor;
using System.IO;

public class CreateFolders : EditorWindow
{
    private string folderName = "NewFolder"; // Ĭ���ļ�������

    [MenuItem("Tools/Create Folders")]
    public static void ShowWindow()
    {
        GetWindow<CreateFolders>("Create Folders");
    }

    private void OnGUI()
    {
        GUILayout.Label("�������ļ���", EditorStyles.boldLabel);
        folderName = EditorGUILayout.TextField("�ļ�������:", folderName);

        if (GUILayout.Button("�����ļ���"))
        {
            CreateEmptyFolders();
        }
    }

    private void CreateEmptyFolders()
    {
        string[] paths = { "Assets/Prefab", "Assets/Resources", "Assets/Scenes", "Assets/Scripts" };

        foreach (string path in paths)
        {
            string newFolderPath = Path.Combine(path, folderName);
            if (!AssetDatabase.IsValidFolder(newFolderPath))
            {
                AssetDatabase.CreateFolder(path, folderName);
                Debug.Log($"�����ļ���: {newFolderPath}");
            }
            else
            {
                Debug.LogWarning($"�ļ����Ѵ���: {newFolderPath}");
            }
        }

        AssetDatabase.Refresh();
    }
}