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
        //go.AddComponent<MeshFilter>().mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");//������Mesh
        //go.AddComponent<MeshRenderer>().material = new Material(Shader.Find("Universal Render Pipeline/Lit"));//������ɫ��

        //��ȡ��Ϸ������Դ
        GameObject assetGo = Resources.Load<GameObject>("Chapter03/Script_03_11_Cube");
        //ʵ������Ϸ��Դ��Hierarchy��ͼ
        GameObject gameObject = GameObject.Instantiate<GameObject>(assetGo);

        //��ȡ������Դ
        Material assetMat = Resources.Load<Material>("Chapter03/Script_03_11_Cube_Material");
        //�޸Ĳ���
        gameObject.GetComponent<MeshRenderer>().material = assetMat;

        Destroy(gameObject);
        Debug.Log(gameObject.name);//������

        DestroyImmediate(gameObject);
        Debug.Log(gameObject.name);//����
    }
}