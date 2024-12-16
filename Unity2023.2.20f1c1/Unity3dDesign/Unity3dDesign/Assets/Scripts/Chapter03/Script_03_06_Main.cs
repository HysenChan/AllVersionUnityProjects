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
}
