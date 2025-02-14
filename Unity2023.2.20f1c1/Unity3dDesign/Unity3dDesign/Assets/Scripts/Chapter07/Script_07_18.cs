using System;
using System.Data.SqlTypes;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Script_07_19 : MonoBehaviour
{
    private float m_Speed = 2.0f;
    private Vector3 m_Dir;
    private void Start()
    {
        //��¼��ʼ��������ɫ�ĳ���
        m_Dir = Camera.main.transform.position - transform.position;
    }

    private void Update()
    {
        //��ȡ��ֱ��ˮƽ�������ֵ
        float pos = Input.GetAxis("Vertical") * m_Speed * Time.deltaTime;
        float ros = Input.GetAxis("Horizontal") * m_Speed;
        //���ҷ����������ת
        if (ros != 0)
        {
            var angle = transform.eulerAngles;
            angle.y += ros;
            transform.eulerAngles = angle;
        }
        //���·���������ƶ�
        Vector3 moveTo = transform.position + (transform.forward * pos);

        //��Ŀ����Ϸ�1�׵�λ�����·�������
        Vector3 rayTop = moveTo;
        rayTop.y += 1f;
        Ray ray = new Ray(rayTop, Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //���������ĸ߶�
            moveTo.y = hit.point.y;
        }
        //������
        Debug.DrawRay(ray.origin, ray.direction, Color.red);
        //���ո�ֵ����ɫ
        transform.position = moveTo;

        //�����������λ�ã�ʼ�ճ����ɫ
        Camera.main.transform.position = transform.position + (transform.rotation * m_Dir);
        Camera.main.transform.LookAt(transform.transform, Vector3.up);
    }
}
