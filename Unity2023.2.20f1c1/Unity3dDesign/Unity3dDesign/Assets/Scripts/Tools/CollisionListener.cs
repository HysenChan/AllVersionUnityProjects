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

    //Å×³öÊÂ¼þ
    private void OnCollisionEnter2D(Collision2D collision)
    {
        onCollisionEnter2D.Invoke(gameObject, collision.collider.gameObject);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        onCollisionStay2D.Invoke(gameObject, collision.collider.gameObject);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        onCollisionExit2D.Invoke(gameObject, collision.collider.gameObject);
    }
}