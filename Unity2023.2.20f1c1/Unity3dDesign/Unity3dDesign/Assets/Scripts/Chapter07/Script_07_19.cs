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
        //控制角色的朝向
        if (move != Vector3.zero)
        {
            transform.forward = move;
        }
        //移动的目标点
        Vector3 moveTo = transform.position + move;

        //从目标点上方1米的位置向下发射射线
        Vector3 rayTop = moveTo;
        rayTop.y += 1f;
        Ray ray = new Ray(rayTop, Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //计算出角色距离地面的高度
            moveTo.y = hit.point.y;
            //画射线
            Debug.DrawRay(ray.origin, ray.direction, Color.red);
            //最终赋值给角色
            transform.position = moveTo;
        }
    }
}
