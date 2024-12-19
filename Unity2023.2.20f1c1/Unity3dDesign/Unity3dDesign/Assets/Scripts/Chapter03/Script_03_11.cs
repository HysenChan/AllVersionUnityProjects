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

        //GameObject root = GameObject.Find("Root");//获取根接点

        //Transform b = root.transform.Find("B");//从根接点获取B对象

        //b.transform.SetAsFirstSibling();//设置为第一个
        //b.transform.SetAsLastSibling();//设置为最后一个

        //Transform a = root.transform.Find("A");//获取A对象
        //b.SetSiblingIndex(a.GetSiblingIndex() + 1);//将B设置到A的后面

        //GameObject root = GameObject.Find("Root");//获取根节点
        //root.transform.Find("A");//获取子节点
        //root.transform.Find("A/Child/B"); //获取带路径的子节点

        //root.transform.GetChild(0);//通过索引获取子节点

        ////只遍历子节点
        //foreach (var child in root.transform) { }
        ////遍历自身节点并且包含所有子孙节点
        //foreach(var item in root.transform.GetComponentsInChildren<Transform>(true)) { }//true代表包含未激活的游戏对象(例如在Hierarchy视图里隐藏的节点)
        ////遍历自身节点并且包含所有父节点
        //foreach(var item in root.transform.GetComponentsInParent<Transform>(true)) { }

        ///通过tag获取对象

        ////获取一个符合Tag名的对象
        //GameObject.FindGameObjectsWithTag("Player");
        ////获取所有符合Tag名的对象
        //foreach (var item in GameObject.FindGameObjectsWithTag("Player")) { }

        //GameObject root = GameObject.Find("Root");//获取根节点
        ////遍历自身节点并且包含所有子孙节点
        //foreach(var item in root.transform.GetComponentsInChildren<Transform>(true))
        //{
        //    if(item.CompareTag("Player"))
        //    {
        //        //判断子节点是否符合Tag名
        //    }
        //}

        ///通过场景获取游戏对象
        ///

        ////方法1：获取当前激活的场景
        //Scene scene = SceneManager.GetActiveScene();
        ////获取场景中的根节点游戏对象
        //foreach (var go in scene.GetRootGameObjects())
        //{
        //    Debug.Log(go.name);
        //}

        ////方法2：
        //for (int i = 0; i < SceneManager.loadedSceneCount; i++)
        //{
        //    foreach (var root in SceneManager.GetSceneAt(i).GetRootGameObjects())
        //    {
        //        Debug.Log(root.name);
        //    }
        //}

        //获取内存中的所有游戏对象
        GameObject.FindFirstObjectByType<GameObject>();
        //获取内存中的所有Script_03_11脚本对象
        GameObject.FindFirstObjectByType<Script_03_11>();
    }
}