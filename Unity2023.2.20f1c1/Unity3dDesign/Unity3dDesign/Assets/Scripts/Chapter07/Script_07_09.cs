using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Audio;
using UnityEngine.Playables;
using UnityEngine.UI;

public class Script_07_09 : MonoBehaviour
{
    private CharacterController m_CharacterController;
    private float m_Speed = 2.0f;

    private void Start()
    {
        m_CharacterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        m_CharacterController.Move(move * Time.deltaTime * m_Speed);
        //���ƽ�ɫ�ĳ���
        if (move != Vector3.zero)
        {
            transform.forward = move;
        }

        //SimpMove
        //���ҷ����������ת
        transform.Rotate(0, Input.GetAxis("Horizontal") * m_Speed, 0);
        //���·���������ƶ�
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float moveSpeed = m_Speed * Input.GetAxis("Vertical");
        m_CharacterController.SimpleMove(forward * moveSpeed);
    }
}
