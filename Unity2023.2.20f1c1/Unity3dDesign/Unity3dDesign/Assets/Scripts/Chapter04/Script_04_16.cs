using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Script_04_16 : MonoBehaviour
{
    public GameObject Root;
    private void Awake()
    {
        Animation animation = Root.GetComponent<Animation>();
        animation.Play();
    }
}