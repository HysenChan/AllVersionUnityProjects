using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_04_01 : MonoBehaviour
{
    //private void Start()
    //{
    //    Text text = GetComponent<Text>();
    //    text.text = "Hello World!";
    //    text.fontSize = 30;
    //    text.font = Resources.Load<Font>("Chapter04/Font0");

    //    Debug.Log("标签:<size=15><color=green>嵌套标签</color></size>");
    //}

    //标记某个字体发生了重建
    private Font m_NeedRebuildFont = null;

    private void Start()
    {
        //监听字体贴图重建事件
        Font.textureRebuilt += delegate (Font font)
        {
            m_NeedRebuildFont = font;
        };
    }

    private void Update()
    {
        Debug.Log(m_NeedRebuildFont);
        if (m_NeedRebuildFont)
        {
            //找到当前场景中的所有Text，刷新一下
            Text[] texts = Object.FindObjectsOfType<Text>();
            if (texts != null)
            {
                foreach (Text text in texts)
                {
                    if (text.font == m_NeedRebuildFont)
                    {
                        text.FontTextureChanged();
                    }
                }
            }
            m_NeedRebuildFont = null;
        }
    }
}
