using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.UI;

public class Script_07_05 : MonoBehaviour
{
    public Slider slider;
    SimpleAnimation m_SimpleAnimation;
    private void Start()
    {
        m_SimpleAnimation = GetComponent<SimpleAnimation>();

        //设置拖动条的最大值是动画的总时间
        slider.minValue = 0;
        slider.maxValue = m_SimpleAnimation["Attack"].length;
        //播放动画并且设置静止开始
        m_SimpleAnimation.Play("Attack");
        m_SimpleAnimation["Attack"].time = 0;
    }

    private void Update()
    {
        //拖动Slider来更新动画播放的进度
        m_SimpleAnimation["Attack"].time = slider.value;
    }
}
