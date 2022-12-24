using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField]
    protected Vector2Int startPosition = Vector2Int.zero;

    [SerializeField]
    private int Iteration = 10;
    [SerializeField]
    public int walkLength = 10;
    [SerializeField]
    public bool startRandomly = true;

    [SerializeField]
    private TilemapDrawer tilemapDrawer;
    public void RunProceduralGeneration()
    {
        HashSet<Vector2Int> floorPositions = RunRandomWalk();
        foreach (Vector2Int pos in floorPositions)
        {
            Debug.Log(pos);
        }
        tilemapDrawer.Clear();

        tilemapDrawer.DrawFloorTiles(floorPositions);
    }

    private HashSet<Vector2Int> RunRandomWalk()
    {
        Vector2Int currentPostiton = startPosition;
        //store all generated vertices in the map
        HashSet<Vector2Int> positions = new();
        for (int i = 0; i < Iteration; i++)
        {
            HashSet<Vector2Int> path = ProceduralGeneration.RandomWalk(currentPostiton, walkLength);
            positions.UnionWith(path);
            //pick a random position as starting point in the next iteration
            if (startRandomly)
            {
                currentPostiton = positions.ElementAt(UnityEngine.Random.Range(0, positions.Count));
            }

        }    
        return positions;
    }
}
