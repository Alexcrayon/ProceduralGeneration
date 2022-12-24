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

    public void RunProceduralGeneration()
    {
        HashSet<Vector2Int> pos = RunRandomWalk();
    }

    private HashSet<Vector2Int> RunRandomWalk()
    {
        Vector2Int currentPostiton = startPosition;
        //store all generated vertices in the map
        HashSet<Vector2Int> pos = new();
        for (int i = 0; i < Iteration; i++)
        {
            HashSet<Vector2Int> path = ProceduralGeneration.RandomWalk(currentPostiton, walkLength);
            pos.UnionWith(path);
            if (startRandomly)
            {
                currentPostiton = pos.ElementAt(UnityEngine.Random.Range(0, pos.Count));
            }

        }    
        return pos;
    }
}
