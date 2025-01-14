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
        //按下鼠标左键
        if (Input.GetMouseButtonDown(0))
        {
            m_Animator.SetInteger("state", 2);
        }
        //抬起鼠标左键
        if (Input.GetMouseButtonUp(0))
        {
            m_Animator.SetInteger("state", 0);
        }

        //按下鼠标右键
        if (Input.GetMouseButtonDown(1))
        {
            m_Animator.SetInteger("state", 1);
        }
        //抬起鼠标右键
        if (Input.GetMouseButtonUp(1))
        {
            m_Animator.SetInteger("state", 0);
        }
    }
}
