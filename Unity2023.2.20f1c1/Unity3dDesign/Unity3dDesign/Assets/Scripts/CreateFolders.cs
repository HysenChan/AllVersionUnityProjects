using UnityEngine;
using UnityEditor;
using System.IO;

public class CreateFolders : EditorWindow
{
    private string folderName = "NewFolder"; // 默认文件夹名称

    [MenuItem("Tools/Create Folders")]
    public static void ShowWindow()
    {
        GetWindow<CreateFolders>("Create Folders");
    }

    private void OnGUI()
    {
        GUILayout.Label("创建空文件夹", EditorStyles.boldLabel);
        folderName = EditorGUILayout.TextField("文件夹名称:", folderName);

        if (GUILayout.Button("创建文件夹"))
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
                Debug.Log($"创建文件夹: {newFolderPath}");
            }
            else
            {
                Debug.LogWarning($"文件夹已存在: {newFolderPath}");
            }
        }

        AssetDatabase.Refresh();
    }
}