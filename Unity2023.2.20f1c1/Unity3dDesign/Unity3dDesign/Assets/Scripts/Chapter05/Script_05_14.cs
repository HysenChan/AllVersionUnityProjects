using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_14 : MonoBehaviour
{
    VisualElement m_Image;
    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;

        m_Image = root.Q<VisualElement>();
        m_Image.RegisterCallback<PointerDownEvent>(OnPointerDown);
        m_Image.RegisterCallback<PointerMoveEvent>(OnPointerMove);
        m_Image.RegisterCallback<PointerUpEvent>(OnPointerUp);
    }
    bool m_Moving = false;
    private void OnPointerDown(PointerDownEvent evt)
    {
        m_Moving = true;
    }

    private void OnPointerMove(PointerMoveEvent evt)
    {
        if(m_Moving)
        {
            var pos = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
            //ת������Ӧ���UI����
            pos = RuntimePanelUtils.ScreenToPanel(m_Image.panel, pos);
            //ͼƬ�Ŀ�߾�Ϊ100���أ�������Ҫȡ���ĵ�
            pos.x -= 100f / 2f;
            pos.y -= 100f / 2f;
            //��������
            m_Image.transform.position = pos;
        }
    }

    private void OnPointerUp(PointerUpEvent evt)
    {
        m_Moving = false;
    }
}
