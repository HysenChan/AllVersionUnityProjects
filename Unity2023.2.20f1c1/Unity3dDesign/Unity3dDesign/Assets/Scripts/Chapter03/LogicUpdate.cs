using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicUpdate : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"Awake {Time.frameCount}");
    }

    private void OnEnable()
    {
        Debug.Log($"OnEnable {Time.frameCount}");
    }

    private void Start()
    {
        Debug.Log($"Start {Time.frameCount}");
    }

    private void Update()
    {
        Debug.Log($"Update {Time.frameCount}");
    }

    private void LateUpdate()
    {
        Debug.Log($"LateUpdate {Time.frameCount}");
    }
}
