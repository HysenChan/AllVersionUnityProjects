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
        //����������
        if (Input.GetMouseButtonDown(0))
        {
            //����Walk����
            AnimationPlayableUtilities.PlayClip(m_Animator, Walk, out var __);
        }
        //̧��������
        if (Input.GetMouseButtonUp(0))
        {
            AnimationPlayableUtilities.PlayClip(m_Animator, Idle, out var __);
        }

        //��������Ҽ�
        if (Input.GetMouseButtonDown(1))
        {
            AnimationPlayableUtilities.PlayClip(m_Animator, Jump, out var __);
        }
        //̧������Ҽ�
        if (Input.GetMouseButtonUp(1))
        {
            AnimationPlayableUtilities.PlayClip(m_Animator, Idle, out var __);
        }
    }
}
