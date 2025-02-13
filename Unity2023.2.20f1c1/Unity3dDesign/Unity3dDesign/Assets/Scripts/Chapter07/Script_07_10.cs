using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Audio;
using UnityEngine.Playables;
using UnityEngine.UI;

public class Script_07_10 : MonoBehaviour
{
    private CharacterController m_CharacterController;
    private float m_Speed = 2.0f;

    private float m_JumpHeight = 3.0f;
    private float m_Gravity = -9.81f;
    private Vector3 m_Velocity;

    private void Start()
    {
        m_CharacterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        //��Ծ�߼�
        bool isGround = m_CharacterController.isGrounded;
        if (isGround)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                //�Ӵ���������������
                m_Velocity.y += Mathf.Sqrt(-(m_JumpHeight * m_Gravity));
            }
            else
            {
                //�Ӵ�������������µ��ٶ�
                m_Velocity.y = 0f;
            }
        }
        m_Velocity.y += m_Gravity * Time.deltaTime;
        m_CharacterController.Move(m_Velocity * Time.deltaTime);

        //�ƶ��߼�
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (isGround) // ���ڵ�����ʱ�������ƶ�
        {
            m_CharacterController.Move(move * Time.deltaTime * m_Speed);
            //���ƽ�ɫ�ĳ���
            if (move != Vector3.zero)
            {
                transform.forward = move;
            }
        }

        //SimpMove
        //���ҷ����������ת
        //transform.Rotate(0, Input.GetAxis("Horizontal") * m_Speed, 0);
        //���·���������ƶ�
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float moveSpeed = m_Speed * Input.GetAxis("Vertical");
        m_CharacterController.SimpleMove(forward * moveSpeed);
    }
}
