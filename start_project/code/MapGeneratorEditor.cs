using System.Collections;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MapGenerate))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MapGenerate mapGen = (MapGenerate)target;

        //������MapGenerate��Inspector�ϵ������б仯
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
