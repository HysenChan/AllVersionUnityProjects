using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script_03_02 : MonoBehaviour
{
    [SerializeField]
    private int Id;
    [SerializeField]
    private GameObject[] Targets;

#if UNITY_EDITOR
    [CustomEditor(typeof(Script_03_02))]
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
            //以默认样式绘制数组数据
            EditorGUILayout.PropertyField(serializedObject.FindProperty(nameof(Targets)), true);
            //保存全部数据
            serializedObject.ApplyModifiedProperties();
        }
    }
#endif
}