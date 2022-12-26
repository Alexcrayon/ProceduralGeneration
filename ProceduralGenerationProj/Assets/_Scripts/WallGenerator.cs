using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class WallGenerator
{
    

    public static void CreateWalls(HashSet<Vector2Int> floorPositions, TilemapDrawer td)
    {
        HashSet<Vector2Int> wallPositions = FindWallsInAllDirections(floorPositions, ProceduralGeneration.Direction);

        foreach(Vector2Int pos in wallPositions)
        {
            td.DrawSingleWall(pos);
        }
    }

    private static HashSet<Vector2Int> FindWallsInAllDirections(HashSet<Vector2Int> floorPositions, List<Vector2Int> directions)
    {
        HashSet<Vector2Int> result = new HashSet<Vector2Int>();

        foreach(Vector2Int pos in floorPositions)
        {
            foreach(Vector2Int dir in directions)
            {
                //Check the neighbour positions to see if it is a floor, if not, then it is a wall
                if(!floorPositions.Contains(pos + dir))
                {
                    result.Add(pos + dir);
                }
            }
        }
        return result;
    }
}
