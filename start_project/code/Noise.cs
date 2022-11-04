using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Noise 
{
    public static float[,] GenerateValueNoiseMap(int mapWidth, int mapHeight)
    {
        float[,] noiseMap = new float[mapWidth, mapHeight];

        for (int y = 0; y < mapHeight; y++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                noiseMap[x, y] = Random.Range(0f,1f);
            }
        }
        return noiseMap;
    }
}
