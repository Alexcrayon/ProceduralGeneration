using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Tilemaps;
public class TilemapDrawer : MonoBehaviour
{
    [SerializeField]
    private Tilemap tilemap;
    
    
    [SerializeField]
    private Tilemap wallTilemap;

    [SerializeField]
    private TileBase floorTile;
    

    [SerializeField]
    private TileBase wallTile;

    public void DrawFloorTiles(IEnumerable<Vector2Int> floorPositions)
    {
        DrawTiles(floorPositions, tilemap, floorTile);
    }

    private void DrawTiles(IEnumerable<Vector2Int> positions, Tilemap tilemap, TileBase floorTile)
    {
        foreach(Vector2Int pos in positions)
        {
            DrawSingleTile(tilemap, floorTile, pos);
        }
    }

    private void DrawSingleTile(Tilemap tilemap, TileBase floorTile, Vector2Int position)
    {
        Vector3Int tilePosition = tilemap.WorldToCell((Vector3Int)position);
        //draw
        tilemap.SetTile(tilePosition, floorTile);
    }


    public void DrawSingleWall(Vector2Int position)
    {
        DrawSingleTile(wallTilemap, wallTile, position);
    }

    /// <summary>
    /// clear the previous drawn tilemap
    /// </summary>
    public void Clear()
    {
        tilemap.ClearAllTiles();
        wallTilemap.ClearAllTiles();
    }

    
}

