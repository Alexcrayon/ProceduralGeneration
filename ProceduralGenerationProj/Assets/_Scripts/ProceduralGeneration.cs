using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public static class ProceduralGeneration 
{
    private static List<Vector2Int> Direction = new List<Vector2Int> {
        new Vector2Int(0,1),    //up    
        new Vector2Int(0,-1),   //down
        new Vector2Int(-1,0),   //left
        new Vector2Int(1,0),    //right
    };


    public static HashSet<Vector2Int> RandomWalk(Vector2Int startPostion, int walkLength)
    {

        HashSet<Vector2Int> path = new HashSet<Vector2Int>();

        path.Add(startPostion);
        Vector2Int previousPostion = startPostion;

        for(int i = 0; i < walkLength; i++)
        {
            //generate a new posistion with random direction
            Vector2Int newPosition = previousPostion + GetRandomDirection();
            path.Add(newPosition);
            previousPostion = newPosition;
        }
        return path;

    }
    public static Vector2Int GetRandomDirection()
    {
        return Direction[Random.Range(0, Direction.Count)];
    }

}


