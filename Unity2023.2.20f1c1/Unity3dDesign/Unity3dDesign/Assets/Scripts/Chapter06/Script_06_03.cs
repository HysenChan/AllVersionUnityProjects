using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Script_06_03 : MonoBehaviour
{
    public AnimationClip Walk;
    public AnimationClip Idle;
    public AnimationClip Jump;
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
            //播放Walk动画
            AnimationPlayableUtilities.PlayClip(m_Animator, Walk, out var __);
        }
        //抬起鼠标左键
        if (Input.GetMouseButtonUp(0))
        {
            AnimationPlayableUtilities.PlayClip(m_Animator, Idle, out var __);
        }

        //按下鼠标右键
        if (Input.GetMouseButtonDown(1))
        {
            AnimationPlayableUtilities.PlayClip(m_Animator, Jump, out var __);
        }
        //抬起鼠标右键
        if (Input.GetMouseButtonUp(1))
        {
            AnimationPlayableUtilities.PlayClip(m_Animator, Idle, out var __);
        }
    }
}
