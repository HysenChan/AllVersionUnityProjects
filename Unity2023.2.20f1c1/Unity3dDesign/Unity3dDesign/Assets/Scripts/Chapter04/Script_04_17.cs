using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Script_04_17 : ScrollRect
{
    protected float m_Radius = 0f;

    protected override void Start()
    {
        base.Start();
        //计算摇动摇杆所形成圆形区域的半径
        m_Radius = (transform as RectTransform).sizeDelta.x * 0.5f;
    }

    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
        var contentPosition = this.content.anchoredPosition;
        if (contentPosition.magnitude > m_Radius)
        {
            contentPosition = contentPosition.normalized * m_Radius;
            SetContentAnchoredPosition(contentPosition);
        }
    }
}