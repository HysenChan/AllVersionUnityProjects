using System.Data.SqlTypes;
using UnityEngine;

public class Script_07_12 : MonoBehaviour
{
    //���������������ƶ�
    public Transform target;
    private void Update()
    {
        //��ȡ����λ��
        var pos = Input.mousePosition;
        //��ȡ�����������ľ���
        pos.z = Mathf.Abs(target.position.z - Camera.main.transform.position.z);
        //��2D����ת����3D����
        target.position = Camera.main.ScreenToWorldPoint(pos);
        if(Input.GetMouseButtonUp(0))
        {
            //����������Ļ�ϵ�����
            Debug.Log(Input.mousePosition);
        }
    }
}
