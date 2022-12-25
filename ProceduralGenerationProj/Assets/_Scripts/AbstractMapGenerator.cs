using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractMapGenerator : MonoBehaviour
{
    [SerializeField]
    protected TilemapDrawer tilemapDrawer = null;
    [SerializeField]
    protected Vector2Int startPosition = Vector2Int.zero;


    public void Generate()
    {
        tilemapDrawer.Clear();
        RunProceduralGeneration();
    }

    protected abstract void RunProceduralGeneration();
}
