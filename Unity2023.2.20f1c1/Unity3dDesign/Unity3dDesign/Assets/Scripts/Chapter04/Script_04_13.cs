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

        //对图片进行监听
        UGUIEventListener.Get(image.gameObject).onClick = OnClick;
    }

    void OnClick(GameObject go)
    {
        if (go == button.gameObject)
        {
            Debug.Log("点击按钮");
        }
        else if (go == image.gameObject)
        {
            Debug.Log("点击图片");
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

    ///获取或者添加UGUIEventListener脚本来实现对游戏对象的监听
    ///

    static public UGUIEventListener Get(GameObject go)
    {
        UGUIEventListener listener = go.GetComponent<UGUIEventListener>();
        if (listener == null)
            listener = go.AddComponent<UGUIEventListener>();
        return listener;
    }
}