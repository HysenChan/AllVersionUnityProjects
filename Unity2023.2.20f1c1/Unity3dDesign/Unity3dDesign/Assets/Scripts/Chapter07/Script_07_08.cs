using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Audio;
using UnityEngine.Playables;
using UnityEngine.UI;

public class Script_07_08 : MonoBehaviour
{
    private void Start()
    {
        SkinnedMeshRenderer smr = GetComponentInChildren<SkinnedMeshRenderer>();
        //����ǰģ���еĹ��������Ƽ�¼���ֵ���
        Dictionary<string, Transform> dict = new Dictionary<string, Transform>();
        foreach (var trans in smr.rootBone.transform.GetComponentsInChildren<Transform>(true))
        {
            dict[trans.name] = trans;
        };

        //����Դ�м����¹���
        SkinnedMeshRenderer sources = Resources.Load<GameObject>("Chapter07/FBX/Mage/Model/NewMage").GetComponentInChildren<SkinnedMeshRenderer>();
        //�����¹�����������䵱ǰģ�͵Ĺ����ڵ�
        Transform[] bones = new Transform[sources.bones.Length];
        for (int i = 0; i < sources.bones.Length; i++)
        {
            string boneName = sources.bones[i].name;
            bones[i] = dict[boneName];
        }

        //�����񡢹������������Ͳ��ʸ�ֵ
        smr.sharedMesh = sources.sharedMesh;
        smr.bones = bones;
        smr.rootBone = dict[sources.rootBone.name];
        smr.material = sources.sharedMaterial;
    }
}
