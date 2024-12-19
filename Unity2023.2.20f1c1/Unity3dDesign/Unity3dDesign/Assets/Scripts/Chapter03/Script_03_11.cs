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
        //GameObject go = new GameObject("Cube");
        //go.transform.position = Vector3.zero;
        //go.AddComponent<MeshFilter>().mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");//立方体Mesh
        //go.AddComponent<MeshRenderer>().material = new Material(Shader.Find("Universal Render Pipeline/Lit"));//设置着色器

        //读取游戏对象资源
        GameObject assetGo = Resources.Load<GameObject>("Chapter03/Script_03_11_Cube");
        //实例化游戏资源到Hierarchy视图
        GameObject gameObject = GameObject.Instantiate<GameObject>(assetGo);

        //读取材质资源
        Material assetMat = Resources.Load<Material>("Chapter03/Script_03_11_Cube_Material");
        //修改材质
        gameObject.GetComponent<MeshRenderer>().material = assetMat;

        Destroy(gameObject);
        Debug.Log(gameObject.name);//不报错

        DestroyImmediate(gameObject);
        Debug.Log(gameObject.name);//报错
    }
}