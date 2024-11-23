using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script_03_04 : MonoBehaviour, ISerializationCallbackReceiver
{
    [SerializeField]
    private List<Sprite> m_Values = new List<Sprite>();
    [SerializeField]
    private List<string> m_Keys = new List<string>();

    public Dictionary<string, Sprite> SpriteDic = new Dictionary<string, Sprite>();

    void ISerializationCallbackReceiver.OnBeforeSerialize()
    {
        //序列化
        m_Keys.Clear();
        m_Values.Clear();
        foreach (KeyValuePair<string, Sprite> pair in SpriteDic)
        {
            m_Keys.Add(pair.Key);
            m_Values.Add(pair.Value);
        }
    }

    void ISerializationCallbackReceiver.OnAfterDeserialize()
    {
        //反序列化
        SpriteDic.Clear();
        if (m_Keys.Count != m_Values.Count)
        {
            Debug.LogError("m_Keys and m_Values 长度不匹配!!!");
        }
        else
        {
            for (int i = 0; i < m_Keys.Count; i++)
            {
                SpriteDic[m_Keys[i]] = m_Values[i];
            }
        }
    }



#if UNITY_EDITOR
    [CustomEditor(typeof(Script_03_04))]
    public class ScriptInsector : Editor
    {
        public override void OnInspectorGUI()
        {
            //更新最新数据
            serializedObject.Update();
            SerializedProperty propertyKey = serializedObject.FindProperty(nameof(m_Keys));
            SerializedProperty propertyValue = serializedObject.FindProperty(nameof(m_Values));

            int size = propertyKey.arraySize;

            GUILayout.BeginVertical();

            for (int i = 0; i < size; i++)
            {
                GUILayout.BeginHorizontal();
                SerializedProperty key = propertyKey.GetArrayElementAtIndex(i);
                SerializedProperty value = propertyValue.GetArrayElementAtIndex(i);
                key.stringValue = EditorGUILayout.TextField("key", key.stringValue);
                value.objectReferenceValue = EditorGUILayout.ObjectField("value",
                    value.objectReferenceValue, typeof(Sprite), false);
                GUILayout.EndHorizontal();
            }
            GUILayout.EndVertical();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("+"))
            {
                (target as Script_03_04).SpriteDic[size.ToString()] = null;
            }
            GUILayout.EndHorizontal();

            //保存全部数据
            serializedObject.ApplyModifiedProperties();
        }
    }
#endif
}
