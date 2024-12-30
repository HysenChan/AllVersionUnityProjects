using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Script_04_19 : MonoBehaviour
{
    public TextMeshProUGUI m_TextMeshProUGUI;

    //采样间隔时间
    public float m_UpdateInterval = 0.5f;
    //采样的总时间
    float m_DeltaTimes = 0.0f;
    //采样的总帧率
    int m_FrameCount = 0;
    //显示帧率
    string m_FpsStr;

    private void Update()
    {
        m_DeltaTimes += Time.unscaledDeltaTime;
        m_FrameCount++;

        //计算这段时间内的平均帧率
        if(m_DeltaTimes>=m_UpdateInterval)
        {
            m_FpsStr = (m_FrameCount / m_DeltaTimes).ToString("F2");
            m_DeltaTimes = 0.0f;
            m_FrameCount = 0;
        }
        m_TextMeshProUGUI.text = m_FpsStr;
    }
}