using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script_03_03 : MonoBehaviour
{
    [SerializeField]
    private int Id;
    [SerializeField]
    private string Name;

#if UNITY_EDITOR
    [CustomEditor(typeof(Script_03_03))]
    public class ScriptInsector : Editor
    {
        public override void OnInspectorGUI()
        {
            //更新最新数据
            serializedObject.Update();
            //获取数据信息
            SerializedProperty propertyId = serializedObject.FindProperty(nameof(Id));
            SerializedProperty propertyName = serializedObject.FindProperty(nameof(Name));

            //开始标记检查
            EditorGUI.BeginChangeCheck();
            propertyId.intValue = EditorGUILayout.IntField("主键", propertyId.intValue);
            //标记检查发生变化
            if (EditorGUI.EndChangeCheck())
            {
                Debug.Log($"主键发生变化:{propertyId.intValue}");
            }
            //开始标记检查
            EditorGUI.BeginChangeCheck();
            propertyName.stringValue = EditorGUILayout.TextField("名字", propertyName.stringValue);
            //标记检查发生变化
            if (EditorGUI.EndChangeCheck())
            {
                Debug.Log($"名字发生变化:{propertyName.stringValue}");
            }
            //判断面板中的任意元素是否有变化
            if (GUI.changed)
            {

            }
            serializedObject.ApplyModifiedProperties();
        }
    }
#endif
}
