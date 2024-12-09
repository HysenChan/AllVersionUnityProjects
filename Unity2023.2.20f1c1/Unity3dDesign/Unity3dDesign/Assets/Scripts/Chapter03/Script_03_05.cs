using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script_03_05 : MonoBehaviour
{
    public int a;//支持
    public List<int> a1;//支持
    public int[] a2;//支持

    public List<List<int>> a3;//不支持
    public Dictionary<int, int> a4;//不支持

    //数组嵌套不支持，可以添加新的类来间接支持
    [System.Serializable]
    public class Data
    {
        public List<int> a;
    }

    public List<Data> a5;//支持

    [SerializeField]
    public List<PlayerInfo> m_PlayerInfo;

    [System.Serializable]
    public class PlayerInfo
    {
        public int id;
        public string name;
    }

    //C#提供了get set属性字段，默认情况下是无法序列化的，可以通过[field:SerializeField]来序列化
    [field: SerializeField]
    public int value { get; private set; }

    [field: SerializeField]
    public int value1 { get; set; }

    [SerializeField]
    public class Data1
    {
        public int Value = 1;
    }
    [SerializeReference]
    public List<Data1> Item;

#if UNITY_EDITOR
    [CustomEditor(typeof(Script_03_05))]
    public class ScriptInsector : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("添加数据"))
            {
                //这里创建了2种数据
                Data1 data1 = new Data1() { Value = 1 };
                Data1 data2 = new Data1() { Value = 2 };
                //在这里添加引用
                //data1和data2虽然被添加了多次，但是只会被序列化一次
                (target as Script_03_05).Item = new List<Data1> { data1, data1, data2, data2 };
            }
            //强制设置场景为dirty状态并重新保存
            EditorUtility.SetDirty(target);
        }
    }
#endif
}
