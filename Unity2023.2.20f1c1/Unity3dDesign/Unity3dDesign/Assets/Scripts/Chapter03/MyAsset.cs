using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MyAsset : AssetPostprocessor
{
    private void OnPostprocessTexture(Texture2D texture)
    {
        context.LogImportError("´íÎó");
        context.LogImportWarning("¾¯¸æ");
    }
}
