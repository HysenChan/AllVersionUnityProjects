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
    public List<Data> Item;
}
