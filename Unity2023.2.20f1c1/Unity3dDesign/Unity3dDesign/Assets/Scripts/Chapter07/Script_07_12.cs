using System.Data.SqlTypes;
using UnityEngine;

public class Script_07_12 : MonoBehaviour
{
    //控制物体跟随鼠标移动
    public Transform target;
    private void Update()
    {
        //获取鼠标的位置
        var pos = Input.mousePosition;
        //获取摄像机与物体的距离
        pos.z = Mathf.Abs(target.position.z - Camera.main.transform.position.z);
        //将2D坐标转换成3D坐标
        target.position = Camera.main.ScreenToWorldPoint(pos);
        if(Input.GetMouseButtonUp(0))
        {
            //输出鼠标在屏幕上的坐标
            Debug.Log(Input.mousePosition);
        }
    }
}
