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
        //通过在面板中绑定数据
        VisualElement inspector = new VisualElement();
        VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Resources/Chapter05/05_21_Template.uxml");
        visualTree.CloneTree(inspector);

        //绘制默认属性
        PropertyField element = new PropertyField(serializedObject.FindProperty("MyIntArray"), "我的数据");
        inspector.Add(element);

        //通过IMGUI的方式绘制
        IMGUIContainer iMGUIContainer = new IMGUIContainer();
        iMGUIContainer.onGUIHandler = () =>
        {
            serializedObject.Update();
            SerializedProperty property = serializedObject.FindProperty("MyCustomFloat");
            property.floatValue = EditorGUILayout.FloatField(new GUIContent("我的浮点"), property.floatValue);
            serializedObject.ApplyModifiedProperties();
        };
        inspector.Add(iMGUIContainer);
        return inspector;
    }
}
#endif