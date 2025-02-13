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
        //将当前模型中的骨骼与名称记录在字典中
        Dictionary<string, Transform> dict = new Dictionary<string, Transform>();
        foreach (var trans in smr.rootBone.transform.GetComponentsInChildren<Transform>(true))
        {
            dict[trans.name] = trans;
        };

        //从资源中加载新骨骼
        SkinnedMeshRenderer sources = Resources.Load<GameObject>("Chapter07/FBX/Mage/Model/NewMage").GetComponentInChildren<SkinnedMeshRenderer>();
        //按照新骨骼的排序填充当前模型的骨骼节点
        Transform[] bones = new Transform[sources.bones.Length];
        for (int i = 0; i < sources.bones.Length; i++)
        {
            string boneName = sources.bones[i].name;
            bones[i] = dict[boneName];
        }

        //给网格、骨骼、根骨骼和材质赋值
        smr.sharedMesh = sources.sharedMesh;
        smr.bones = bones;
        smr.rootBone = dict[sources.rootBone.name];
        smr.material = sources.sharedMaterial;
    }
}
