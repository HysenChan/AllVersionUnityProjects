using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneTemplate;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneTemplatePipeline : ISceneTemplatePipeline
{
    public void AfterTemplateInstantiation(SceneTemplateAsset sceneTemplateAsset, Scene scene, bool isAdditive, string sceneName)
    {
        //在通过模板创建新场景之后执行
    }

    public void BeforeTemplateInstantiation(SceneTemplateAsset sceneTemplateAsset, bool isAdditive, string sceneName)
    {
        //在通过模板创建新场景之前执行
    }

    public bool IsValidTemplateForInstantiation(SceneTemplateAsset sceneTemplateAsset)
    {
        //是否允许创建该模板
        return true;
    }
}
