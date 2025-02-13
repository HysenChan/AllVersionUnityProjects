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

        //�����϶��������ֵ�Ƕ�������ʱ��
        slider.minValue = 0;
        slider.maxValue = m_SimpleAnimation["Attack"].length;
        //���Ŷ����������þ�ֹ��ʼ
        m_SimpleAnimation.Play("Attack");
        m_SimpleAnimation["Attack"].time = 0;
    }

    private void Update()
    {
        //�϶�Slider�����¶������ŵĽ���
        m_SimpleAnimation["Attack"].time = slider.value;
    }
}
