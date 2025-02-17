using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_08_01 : MonoBehaviour
{
    //�決��ͼ1
    public Texture2D lightmap1;
    //�決��ͼ2
    public Texture2D lightmap2;

    private void OnGUI()
    {
        if (GUILayout.Button("<size=50>lightmap1</size>"))
        {
            LightmapData data = new LightmapData();
            data.lightmapColor = lightmap1;
            LightmapSettings.lightmaps = new LightmapData[1] { data };
        }

        if (GUILayout.Button("<size=50>lightmap2</size>"))
        {
            LightmapData data = new LightmapData();
            data.lightmapColor = lightmap2;
            LightmapSettings.lightmaps = new LightmapData[1] { data };
        }
    }
}
