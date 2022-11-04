using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Noise 
{
    public static float[,] GenerateNoiseMap(int mapWidth, int mapHeight,float scale)
    {
        float[,] noiseMap = new float[mapWidth, mapHeight];

        //防止除以0，除以负数
        if (scale <= 0)
        {
            scale = 0.0001f;
        }


        for (int y = 0; y < mapHeight; y++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                //1.值噪声
                noiseMap[x, y] = Random.Range(0f,1f);


                //2.使用unity的柏林函数
                /*
                float sampleX = x / scale;
                float sampleY = y / scale;
                float perlinValue = Mathf.PerlinNoise(sampleX, sampleY);
                noiseMap[x, y] = perlinValue;
                */
            }
        }
        return noiseMap;
    }
}
