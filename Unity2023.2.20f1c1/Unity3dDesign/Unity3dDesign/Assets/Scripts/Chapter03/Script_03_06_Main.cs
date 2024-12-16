using UnityEngine;

public class Script_03_06_Main : MonoBehaviour
{
    void Start()
    {
        Script_03_06 script = Resources.Load<Script_03_06>("Chapter03/Script_03_06");
        foreach (var info in script.m_PlayerInfo)
        {
            Debug.LogFormat($"name : {info.name} id : {info.id}");
        }
    }

    [Header("Header1")]
    public int a;
    public float b;

    [Header("Header2")]
    public int a2;
    public float b2;

    public enum Type
    {
        [InspectorName("第一")]
        One,
        [InspectorName("第二")]
        Two,
    }
    public Type type;
}
