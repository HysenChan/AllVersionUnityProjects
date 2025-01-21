using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Tilemaps;

public class Script_06_06 : MonoBehaviour
{
    public Tilemap tilemap;
    public TileBase tile1;
    private void Update()
    {
        //通过发送射线获取鼠标在Tile中的世界坐标点
        RaycastHit2D raycast = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (raycast.collider)
        {
            //获取索引并刷新Tile
            Vector3Int i = tilemap.WorldToCell(raycast.point);
            tilemap.SetTile(i, tile1);
        }
    }
}
