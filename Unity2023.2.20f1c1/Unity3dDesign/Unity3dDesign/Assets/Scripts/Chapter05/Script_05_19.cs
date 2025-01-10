using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_19 : MonoBehaviour
{
    public int MyValue;
    public float MyCustomFloat;
    public List<int> MyIntArray;
}

#if UNITY_EDITOR
[CustomEditor(typeof(Script_05_19))]
public class Script_05_19Editor : Editor
{
    public override VisualElement CreateInspectorGUI()
    {
        //ͨ��������а�����
        VisualElement inspector = new VisualElement();
        VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Resources/Chapter05/05_21_Template.uxml");
        visualTree.CloneTree(inspector);

        //����Ĭ������
        PropertyField element = new PropertyField(serializedObject.FindProperty("MyIntArray"), "�ҵ�����");
        inspector.Add(element);

        //ͨ��IMGUI�ķ�ʽ����
        IMGUIContainer iMGUIContainer = new IMGUIContainer();
        iMGUIContainer.onGUIHandler = () =>
        {
            serializedObject.Update();
            SerializedProperty property = serializedObject.FindProperty("MyCustomFloat");
            property.floatValue = EditorGUILayout.FloatField(new GUIContent("�ҵĸ���"), property.floatValue);
            serializedObject.ApplyModifiedProperties();
        };
        inspector.Add(iMGUIContainer);
        return inspector;
    }
}
#endif