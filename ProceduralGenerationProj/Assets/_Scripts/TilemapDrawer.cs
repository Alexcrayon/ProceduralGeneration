using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class TilemapDrawer : MonoBehaviour
{
    [SerializeField]
    private Tilemap tilemap;
    [SerializeField]
    private TileBase floorTile;

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

    /// <summary>
    /// clear the previous drawn tilemap
    /// </summary>
    public void Clear()
    {
        tilemap.ClearAllTiles();
    }
}

