using System;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Script_07_15 : MonoBehaviour
{
    //ģ��
    public Transform Model;
    //3dtextMesh
    public TextMesh TextMesh;
    //�ƶ���Ŀ�ĵ�
    private Vector3 m_MoveToPosition = Vector3.zero;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //�泯�����ĵ�
                m_MoveToPosition = new Vector3(hit.point.x, Model.position.y, hit.point.z);
                Model.LookAt(m_MoveToPosition);

                TextMesh.text = string.Format("���λ��{0}", hit.point);
                TextMesh.transform.position = hit.point;
            }
        }
        if (Model.position != m_MoveToPosition)
        {
            //����
            float step = 5f * Time.deltaTime;
            Model.position = Vector3.MoveTowards(Model.position, m_MoveToPosition, step);
        }
    }
}
