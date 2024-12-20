using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_04_01 : MonoBehaviour
{
    private void Start()
    {
        Text text = GetComponent<Text>();
        text.text = "Hello World!";
        text.fontSize = 30;
        text.font = Resources.Load<Font>("Chapter04/Font");
    }
}
