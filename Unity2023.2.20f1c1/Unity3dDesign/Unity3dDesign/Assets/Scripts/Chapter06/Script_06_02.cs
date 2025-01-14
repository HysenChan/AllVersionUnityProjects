using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_06_02 : MonoBehaviour
{
    private Animator m_Animator;

    private void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    private void Update()
    {
        //����������
        if (Input.GetMouseButtonDown(0))
        {
            m_Animator.SetInteger("state", 2);
        }
        //̧��������
        if (Input.GetMouseButtonUp(0))
        {
            m_Animator.SetInteger("state", 0);
        }

        //��������Ҽ�
        if (Input.GetMouseButtonDown(1))
        {
            m_Animator.SetInteger("state", 1);
        }
        //̧������Ҽ�
        if (Input.GetMouseButtonUp(1))
        {
            m_Animator.SetInteger("state", 0);
        }
    }
}
