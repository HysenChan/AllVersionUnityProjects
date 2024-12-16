using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CreateAssetMenu(fileName = "MyAsset1", menuName = "游戏资源", order = 0)]
public class Script_03_06 : ScriptableObject
{
    [SerializeField]
    public List<PlayerInfo> m_PlayerInfo;

    [System.Serializable]
    public class PlayerInfo
    {
        public int id;
        public string name;
    }


    [MenuItem("Assets/Create ScriptableObject")]
    static void CreateScriptableObject()
    {
        //创建ScriptableObject
        Script_03_06 script = ScriptableObject.CreateInstance<Script_03_06>();
        //赋值
        script.m_PlayerInfo = new List<Script_03_06.PlayerInfo>();
        script.m_PlayerInfo.Add(new Script_03_06.PlayerInfo() { id = 100, name = "Test" });

        //将资源保存到本地
        AssetDatabase.CreateAsset(script, "Assets/Resources/Chapter03/Create Script_03_06.asset");
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

}


