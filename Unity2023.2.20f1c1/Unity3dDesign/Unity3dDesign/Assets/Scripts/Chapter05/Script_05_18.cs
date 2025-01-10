using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_18 : MonoBehaviour
{
    [System.Serializable]
    public class Data
    {
        public float a;
        public int b;
    }
    public int MyValue;
    public Vector2 MyPosition;
    public GameObject MyGameObject;
    public List<Data> Mydata;
}

#if UNITY_EDITOR
[CustomEditor(typeof(Script_05_18))]
public class Script_05_18Editor : Editor
{
    public override VisualElement CreateInspectorGUI()
    {
        VisualElement inspector = new VisualElement();
        VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Resources/Chapter05/05_20_Template.uxml");
        visualTree.CloneTree(inspector);

        inspector.Q<Button>().clicked += () =>
        {
            Debug.Log("µã»÷°´Å¥");
        };

        return inspector;
    }
}
#endif