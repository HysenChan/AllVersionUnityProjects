using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("��갴����ײ��ʱ����");
    }

    private void OnMouseUp()
    {
        Debug.Log("���̧����ײ��ʱ����");
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("����ɿ���ײ��ʱ���ã�ִ��ʱ����OnMouseUp֮ǰ");
    }

    private void OnMouseEnter()
    {
        Debug.Log("��������ײ��ʱ����");
    }

    private void OnMouseDrag()
    {
        Debug.Log("����϶���ײ��ʱ����");
    }

    private void OnMouseExit()
    {
        Debug.Log("����뿪��ײ��ʱ����");
    }

    private void OnMouseOver()
    {
        //Debug.Log("�����������ײ����ʱ����");
    }
}
