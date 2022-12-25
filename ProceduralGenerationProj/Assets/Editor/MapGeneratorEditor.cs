using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(AbstractMapGenerator), true)]
public class MapGeneratorEditor : Editor
{
    AbstractMapGenerator generator;

    private void Awake()
    {
        generator = (AbstractMapGenerator)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        //create a button in instpector ui
        if(GUILayout.Button("Create Map"))
        {
            generator.Generate();
        }
    }
}
