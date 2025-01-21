using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Tilemaps;

public class CustomTile : Tile
{
    //需要刷新某个Tile时调用
    public override void RefreshTile(Vector3Int location, ITilemap tilemap)
    {
        base.RefreshTile(location, tilemap);
    }

    //需要获取某个TileData时调用
    public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
    {
        base.GetTileData(position, tilemap, ref tileData);
    }

    //获取Tile动画数据时调用
    public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
    {
        return base.GetTileAnimationData(position, tilemap, ref tileAnimationData);
    }

    //启动时首次调用
    public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
    {
        return base.StartUp(position, tilemap, go);
    }

#if UNITY_EDITOR
    [MenuItem("Assets/Create/CustomTile")]
    public static void CreateRoadTile()
    {
        string path = EditorUtility.SaveFilePanelInProject("Save Custom Tile", "New Custom Tile", "Asset", "Save Custom Tile", "Assets");
        if (path == "")
            return;
        AssetDatabase.CreateAsset(ScriptableObject.CreateInstance<CustomTile>(), path);
    }
#endif
}