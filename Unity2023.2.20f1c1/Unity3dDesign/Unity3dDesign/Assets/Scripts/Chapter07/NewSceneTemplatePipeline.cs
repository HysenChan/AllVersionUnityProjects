using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneTemplate;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneTemplatePipeline : ISceneTemplatePipeline
{
    public void AfterTemplateInstantiation(SceneTemplateAsset sceneTemplateAsset, Scene scene, bool isAdditive, string sceneName)
    {
        //��ͨ��ģ�崴���³���֮��ִ��
    }

    public void BeforeTemplateInstantiation(SceneTemplateAsset sceneTemplateAsset, bool isAdditive, string sceneName)
    {
        //��ͨ��ģ�崴���³���֮ǰִ��
    }

    public bool IsValidTemplateForInstantiation(SceneTemplateAsset sceneTemplateAsset)
    {
        //�Ƿ���������ģ��
        return true;
    }
}
