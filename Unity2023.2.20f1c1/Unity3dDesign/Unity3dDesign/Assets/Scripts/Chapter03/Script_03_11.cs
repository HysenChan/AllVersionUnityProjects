using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements.Experimental;

public class Script_03_11 : MonoBehaviour
{
    private void Start()
    {
        GameObject go = new GameObject("Cube");
        go.transform.position = Vector3.zero;
        go.AddComponent<MeshFilter>().mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");//立方体Mesh
        go.AddComponent<MeshRenderer>().material = new Material(Shader.Find("Universal Render Pipeline/Lit"));//设置着色器
    }
}