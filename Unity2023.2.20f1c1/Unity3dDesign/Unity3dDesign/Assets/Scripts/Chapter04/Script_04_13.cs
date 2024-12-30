using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Script_04_13 : MonoBehaviour
{
    public Button button;
    public Image image;

    private void Awake()
    {
        button.onClick.AddListener(delegate ()
        {
            OnClick(button.gameObject);
        });

        //��ͼƬ���м���
        UGUIEventListener.Get(image.gameObject).onClick = OnClick;
    }

    void OnClick(GameObject go)
    {
        if (go == button.gameObject)
        {
            Debug.Log("�����ť");
        }
        else if (go == image.gameObject)
        {
            Debug.Log("���ͼƬ");
        }
    }
}

public class UGUIEventListener : EventTrigger
{
    public UnityAction<GameObject> onClick;

    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);

        if (onClick != null)
        {
            onClick(gameObject);
        }
    }

    ///��ȡ�������UGUIEventListener�ű���ʵ�ֶ���Ϸ����ļ���
    ///

    static public UGUIEventListener Get(GameObject go)
    {
        UGUIEventListener listener = go.GetComponent<UGUIEventListener>();
        if (listener == null)
            listener = go.AddComponent<UGUIEventListener>();
        return listener;
    }
}