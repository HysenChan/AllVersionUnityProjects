using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Tilemaps;

public class Script_06_07 : MonoBehaviour
{
    public Rigidbody2D heroRigibody2D;

    private void Update()
    {
        //�������
        if (Input.GetKey(KeyCode.W))
        {
            Run(Vector2.up);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            Run(Vector2.right, false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Run(Vector2.left, true);
        }
    }

    void Run(Vector2 position, bool flipx = false)
    {
        //��Rigidbody�Ժ󣬲�����ʹ��transform.position��ֵ
        heroRigibody2D.position += (position * 0.1f);
        //��AD������л�����
        heroRigibody2D.transform.rotation = flipx ? Quaternion.Euler(0f, -180f, 0f) : Quaternion.Euler(Vector3.zero);
    }
}
