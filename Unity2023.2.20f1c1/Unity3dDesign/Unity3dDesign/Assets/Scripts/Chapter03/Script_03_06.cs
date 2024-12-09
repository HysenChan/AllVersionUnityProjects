using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static Script_03_06;

public class Script_03_06 : MonoBehaviour
{
    [Serializable]
    public class Data
    {
        public int Value = 1;
    }
    [Serializable]
    public class Child1 : Data
    {
        public float FloatValue;
    }
    [Serializable]
    public class Child2 : Data
    {
        public int IntValue;
    }
    public List<Child1> Item1;
    public List<Child2> Item2;

    public void PrintValues()
    {
        foreach (var item in Item1)
        {
            Debug.Log($"Child1 - Value: {item.Value}, FloatValue: {item.FloatValue}");
        }

        foreach (var item in Item2)
        {
            Debug.Log($"Child2 - Value: {item.Value}, IntValue: {item.IntValue}");
        }
    }

    private void Start()
    {
        PrintValues();
    }
}

[CustomEditor(typeof(Script_03_06))]
public class Script_03_06Editor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("添加数据"))
        {
            //这里创建了2种数据
            Child1 data1 = new Child1() { FloatValue = 0.01f };
            Child2 data2 = new Child2() { IntValue = 1000 };
            //在这里添加引用
            //data1和data2虽然被添加了多次，但是只会被序列化一次
            var script = target as Script_03_06;
            script.Item1.Add(data1);
            script.Item1.Add(data1);
            script.Item2.Add(data2);
            script.Item2.Add(data2);
            //强制设置场景为dirty状态并重新保存
            EditorUtility.SetDirty(target);
        }
    }
}