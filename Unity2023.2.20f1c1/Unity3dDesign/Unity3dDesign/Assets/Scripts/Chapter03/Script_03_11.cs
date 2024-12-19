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

        ////读取游戏对象资源
        //GameObject assetGo = Resources.Load<GameObject>("Chapter03/Script_03_11_Cube");
        ////实例化游戏资源到Hierarchy视图
        //GameObject gameObject = GameObject.Instantiate<GameObject>(assetGo);

        ////读取材质资源
        //Material assetMat = Resources.Load<Material>("Chapter03/Script_03_11_Cube_Material");
        ////修改材质
        //gameObject.GetComponent<MeshRenderer>().material = assetMat;

        //Destroy(gameObject);
        //Debug.Log(gameObject.name);//不报错

        //DestroyImmediate(gameObject);
        //Debug.Log(gameObject.name);//报错

        //GameObject go = new GameObject("go");
        //GameObject go2 = new GameObject("go2");

        ////将go2放在顶层节点下
        //go2.transform.SetParent(null, false);

        ////将go2放在go的节点下
        //go2.transform.SetParent(go.transform, false);

        GameObject root = GameObject.Find("Root");//获取根接点

        Transform b = root.transform.Find("B");//从根接点获取B对象

        b.transform.SetAsFirstSibling();//设置为第一个
        b.transform.SetAsLastSibling();//设置为最后一个

        Transform a = root.transform.Find("A");//获取A对象
        b.SetSiblingIndex(a.GetSiblingIndex() + 1);//将B设置到A的后面
    }
}