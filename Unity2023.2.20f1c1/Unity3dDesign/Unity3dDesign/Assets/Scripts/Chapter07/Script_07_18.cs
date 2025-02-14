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
        //记录初始摄像机与角色的朝向
        m_Dir = Camera.main.transform.position - transform.position;
    }

    private void Update()
    {
        //获取垂直和水平方向轴的值
        float pos = Input.GetAxis("Vertical") * m_Speed * Time.deltaTime;
        float ros = Input.GetAxis("Horizontal") * m_Speed;
        //左右方向键控制旋转
        if (ros != 0)
        {
            var angle = transform.eulerAngles;
            angle.y += ros;
            transform.eulerAngles = angle;
        }
        //上下方向键控制移动
        Vector3 moveTo = transform.position + (transform.forward * pos);

        //从目标点上方1米的位置向下发送射线
        Vector3 rayTop = moveTo;
        rayTop.y += 1f;
        Ray ray = new Ray(rayTop, Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //计算出地面的高度
            moveTo.y = hit.point.y;
        }
        //画射线
        Debug.DrawRay(ray.origin, ray.direction, Color.red);
        //最终赋值给角色
        transform.position = moveTo;

        //计算摄像机的位置，始终朝向角色
        Camera.main.transform.position = transform.position + (transform.rotation * m_Dir);
        Camera.main.transform.LookAt(transform.transform, Vector3.up);
    }
}
