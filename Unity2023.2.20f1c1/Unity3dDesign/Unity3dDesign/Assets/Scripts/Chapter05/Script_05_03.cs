using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_03 : MonoBehaviour
{
    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;
        var label = root.Q<Label>("MyLabel");
        //����ı����Խ��ܵ��
        label.focusable = true;
        label.enableRichText = true;
        label.style.fontSize = 50;
        label.text = "<sprite name=EmojiOne_1>ͼ�Ļ��� <u><link=\"ID_1\">�����»���</link></u>";
        //�����ı���������¼�
        label.RegisterCallback<ClickEvent>((evt) => { Debug.Log($"click"); });
        //�����¼���ȡlink������
        label.RegisterCallback<PointerDownLinkTagEvent>((evt) => { Debug.Log($"LinkID:{evt.linkID}"); });
    }
}
