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

        ////��ȡ��Ϸ������Դ
        //GameObject assetGo = Resources.Load<GameObject>("Chapter03/Script_03_11_Cube");
        ////ʵ������Ϸ��Դ��Hierarchy��ͼ
        //GameObject gameObject = GameObject.Instantiate<GameObject>(assetGo);

        ////��ȡ������Դ
        //Material assetMat = Resources.Load<Material>("Chapter03/Script_03_11_Cube_Material");
        ////�޸Ĳ���
        //gameObject.GetComponent<MeshRenderer>().material = assetMat;

        //Destroy(gameObject);
        //Debug.Log(gameObject.name);//������

        //DestroyImmediate(gameObject);
        //Debug.Log(gameObject.name);//����

        //GameObject go = new GameObject("go");
        //GameObject go2 = new GameObject("go2");

        ////��go2���ڶ���ڵ���
        //go2.transform.SetParent(null, false);

        ////��go2����go�Ľڵ���
        //go2.transform.SetParent(go.transform, false);

        //GameObject root = GameObject.Find("Root");//��ȡ���ӵ�

        //Transform b = root.transform.Find("B");//�Ӹ��ӵ��ȡB����

        //b.transform.SetAsFirstSibling();//����Ϊ��һ��
        //b.transform.SetAsLastSibling();//����Ϊ���һ��

        //Transform a = root.transform.Find("A");//��ȡA����
        //b.SetSiblingIndex(a.GetSiblingIndex() + 1);//��B���õ�A�ĺ���

        GameObject root = GameObject.Find("Root");//��ȡ���ڵ�
        root.transform.Find("A");//��ȡ�ӽڵ�
        root.transform.Find("A/Child/B"); //��ȡ��·�����ӽڵ�

        root.transform.GetChild(0);//ͨ��������ȡ�ӽڵ�

        //ֻ�����ӽڵ�
        foreach (var child in root.transform) { }
        //���������ڵ㲢�Ұ�����������ڵ�
        foreach(var item in root.transform.GetComponentsInChildren<Transform>(true)) { }//true��������δ�������Ϸ����
        //���������ڵ㲢�Ұ������и��ڵ�
        foreach(var item in root.transform.GetComponentsInParent<Transform>(true)) { }
    }
}