using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// A custom object can be created through asset menu that store the parameters of different types of map
/// including iteration, walkLength, start randomly
/// Genterator use this object as reference to generate maps
/// </summary>
[CreateAssetMenu(fileName = "MapDataType_", menuName = "Procedural Generation/MapData")]
public class MapData : ScriptableObject
{
    //how many time to iterate when generating a path
    public int iteration = 10;
    //the length of path for a each generation
    public int walkLength = 10;
    //From each new iteration, pick whether to start the path from point (0,0) or a random point from previous iteration 
    public bool startRandomly = true;
}
