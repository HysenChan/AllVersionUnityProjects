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

    //    Debug.Log("��ǩ:<size=15><color=green>Ƕ�ױ�ǩ</color></size>");
    //}

    //���ĳ�����巢�����ؽ�
    private Font m_NeedRebuildFont = null;

    private void Start()
    {
        //����������ͼ�ؽ��¼�
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
            //�ҵ���ǰ�����е�����Text��ˢ��һ��
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
