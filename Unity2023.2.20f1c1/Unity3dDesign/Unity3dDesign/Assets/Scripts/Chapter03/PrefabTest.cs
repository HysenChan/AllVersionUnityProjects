using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    [System.NonSerialized]
    public int Id;
    [HideInInspector]
    public string Name;
    public GameObject Prefab;
    [SerializeField]
    private bool isBool;
}
