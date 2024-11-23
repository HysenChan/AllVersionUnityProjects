using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script_03_01 : MonoBehaviour
{
    [SerializeField]
    private int Id;
    [SerializeField]
    private string Name;
    [SerializeField]
    private GameObject Prefab;

#if UNITY_EDITOR
    [CustomEditor(typeof(Script_03_01))]
    public class ScriptInsector : Editor
    {
        public override void OnInspectorGUI()
        {
            //更新最新数据
            serializedObject.Update();
            //获取数据信息
            SerializedProperty property = serializedObject.FindProperty(nameof(Id));
            //赋值数据
            property.intValue = EditorGUILayout.IntField("主键", property.intValue);

            property = serializedObject.FindProperty(nameof(Name));
            property.stringValue = EditorGUILayout.TextField("姓名", property.stringValue);

            property = serializedObject.FindProperty(nameof(Prefab));
            property.objectReferenceValue = EditorGUILayout.ObjectField("游戏对象",
                property.objectReferenceValue, typeof(GameObject), true);

            //保存全部数据
            serializedObject.ApplyModifiedProperties();
        }
    }
#endif
}
