using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Tilemaps;

public class CollisionEvent : UnityEvent<GameObject, GameObject> { }
public class CollisionListener : MonoBehaviour
{
    static public CollisionListener Get(GameObject go)
    {
        CollisionListener listener = go.GetComponent<CollisionListener>();
        if (listener == null)
            listener = go.AddComponent<CollisionListener>();
        return listener;
    }

    public CollisionEvent onCollisionEnter2D = new CollisionEvent();
    public CollisionEvent onCollisionStay2D = new CollisionEvent();
    public CollisionEvent onCollisionExit2D = new CollisionEvent();

    //抛出事件
    private void OnCollisionEnter2D(Collision2D collision)
    {
        onCollisionEnter2D.Invoke(gameObject, collision.collider.gameObject);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        //onCollisionStay2D.Invoke(gameObject, collision.collider.gameObject);
        foreach (ContactPoint2D contact in collision.contacts)
        {
            //绘制线段
            Debug.DrawLine(contact.point, transform.position, Color.red);
            var direction = transform.InverseTransformPoint(contact.point);
            if (direction.x > 0f)
                print("右碰撞");
            if (direction.x < 0f)
                print("左碰撞");
            if (direction.y > 0f)
                print("上碰撞");
            if (direction.y < 0f)
                print("下碰撞");
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        onCollisionExit2D.Invoke(gameObject, collision.collider.gameObject);
    }
}