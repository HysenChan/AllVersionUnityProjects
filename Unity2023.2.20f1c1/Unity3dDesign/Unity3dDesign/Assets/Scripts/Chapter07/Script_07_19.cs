using System;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Script_07_18 : MonoBehaviour
{
    private float m_Speed = 2.0f;
    private void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * m_Speed * Time.deltaTime;
        //���ƽ�ɫ�ĳ���
        if (move != Vector3.zero)
        {
            transform.forward = move;
        }
        //�ƶ���Ŀ���
        Vector3 moveTo = transform.position + move;

        //��Ŀ����Ϸ�1�׵�λ�����·�������
        Vector3 rayTop = moveTo;
        rayTop.y += 1f;
        Ray ray = new Ray(rayTop, Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //�������ɫ�������ĸ߶�
            moveTo.y = hit.point.y;
            //������
            Debug.DrawRay(ray.origin, ray.direction, Color.red);
            //���ո�ֵ����ɫ
            transform.position = moveTo;
        }
    }
}
