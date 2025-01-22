using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Tilemaps;

public class Script_06_08 : MonoBehaviour
{
    public Rigidbody2D heroRigidbody2D;

    private void Start()
    {
        //������ײ
        var collision = CollisionListener.Get(heroRigidbody2D.gameObject);
        collision.onCollisionEnter2D.AddListener((g1, g2) => { Debug.LogFormat("{0}��ʼ��ײ{1}", g1.name, g2.name); });
        collision.onCollisionStay2D.AddListener((g1, g2) => { Debug.LogFormat("{0}��ײ��{1}", g1.name, g2.name); });
        collision.onCollisionExit2D.AddListener((g1, g2) => { Debug.LogFormat("{0}������ײ{1}", g1.name, g2.name); });
    }

    private void Update()
    {
        //�������
        if (Input.GetKey(KeyCode.W))
        {
            Run(Vector2.up);
        }
        else if (Input.GetKey(KeyCode.D))
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
        heroRigidbody2D.position += (position * 0.1f);
        //��AD������л�����
        heroRigidbody2D.transform.rotation = flipx ? Quaternion.Euler(0f, -180f, 0f) : Quaternion.Euler(Vector3.zero);
    }
}
