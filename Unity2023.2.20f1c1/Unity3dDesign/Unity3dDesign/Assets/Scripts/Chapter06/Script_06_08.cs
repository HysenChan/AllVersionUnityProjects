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
        //监听碰撞
        var collision = CollisionListener.Get(heroRigidbody2D.gameObject);
        collision.onCollisionEnter2D.AddListener((g1, g2) => { Debug.LogFormat("{0}开始碰撞{1}", g1.name, g2.name); });
        collision.onCollisionStay2D.AddListener((g1, g2) => { Debug.LogFormat("{0}碰撞中{1}", g1.name, g2.name); });
        collision.onCollisionExit2D.AddListener((g1, g2) => { Debug.LogFormat("{0}结束碰撞{1}", g1.name, g2.name); });
    }

    private void Update()
    {
        //处理方向键
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
        //绑定Rigidbody以后，不能再使用transform.position赋值
        heroRigidbody2D.position += (position * 0.1f);
        //按AD方向键切换朝向
        heroRigidbody2D.transform.rotation = flipx ? Quaternion.Euler(0f, -180f, 0f) : Quaternion.Euler(Vector3.zero);
    }
}
