using System.Data.SqlTypes;
using UnityEngine;

public class Script_07_11 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("����A���¼�");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("��������A���¼�");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("�ͷ�A���¼�");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("����������");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("���ְ���������");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("�ͷ�������");
        }

        if (Input.touchCount > 0)
        {
            //��㴥��
            for (int i = 0; i < Input.touchCount; i++)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    Debug.Log($"��{i}����ָ������ʼ");
                }
                else if (Input.GetTouch(i).phase == TouchPhase.Moved)
                {
                    Debug.Log($"��{i}����ָ���������ƶ�");
                }
                else if (Input.GetTouch(i).phase == TouchPhase.Ended)
                {
                    Debug.Log($"��{i}����ָ��������");
                }
                else if (Input.GetTouch(i).phase == TouchPhase.Canceled)
                {
                    Debug.Log($"��{i}����ָ������ȡ��");
                }
                else if (Input.GetTouch(i).phase == TouchPhase.Stationary)
                {
                    Debug.Log($"��{i}����ָ������û���ƶ�");
                }
                else if (Input.touchPressureSupported)
                {
                    Debug.LogFormat("3DTouch������:{0}", Input.GetTouch(i).pressure);
                }
            }
        }
    }
}
