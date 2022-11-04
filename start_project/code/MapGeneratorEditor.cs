using System.Collections;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MapGenerate))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MapGenerate mapGen = (MapGenerate)target;

        //监听到MapGenerate的Inspector上的数据有变化
        if (DrawDefaultInspector())
        {
            if (mapGen.autoUpdate)
            {
                mapGen.GenerateMap();
            }
        }


        DrawDefaultInspector();
        if (GUILayout.Button("Generate"))
        {
            mapGen.GenerateMap();
        }
    }
}
