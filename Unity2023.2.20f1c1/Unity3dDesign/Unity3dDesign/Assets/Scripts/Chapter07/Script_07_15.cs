using System;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Script_07_15 : MonoBehaviour
{
    //模型
    public Transform Model;
    //3dtextMesh
    public TextMesh TextMesh;
    //移动到目的地
    private Vector3 m_MoveToPosition = Vector3.zero;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //面朝向点击的点
                m_MoveToPosition = new Vector3(hit.point.x, Model.position.y, hit.point.z);
                Model.LookAt(m_MoveToPosition);

                TextMesh.text = string.Format("点击位置{0}", hit.point);
                TextMesh.transform.position = hit.point;
            }
        }
        if (Model.position != m_MoveToPosition)
        {
            //步长
            float step = 5f * Time.deltaTime;
            Model.position = Vector3.MoveTowards(Model.position, m_MoveToPosition, step);
        }
    }
}
