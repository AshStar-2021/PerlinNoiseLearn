using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerate : MonoBehaviour
{
	public int mapWidth;
	public int mapHeight;
	public float noiseScale = 10f;

	[Range(1, 100)]
	public int octaves;			//度，需要大于1
	[Range(0, 1)]
	public float persistance;	//持久度，需要大于0，小于1
	[Range(1, 20)]
	public float lacunarity;    //间隙度，控制频率，需要大于1
	
	public int seed;
	public Vector2 offset;

	//是否开启在编辑器中自动更新
	public bool autoUpdate = true;
	public void GenerateMap()
	{
		//生成噪声
		float[,] noiseMap = Noise.GenerateNoiseMap(mapWidth, mapHeight, seed, noiseScale, octaves,persistance,lacunarity,offset);

		//显示在Plane上
		MapDisplay display = FindObjectOfType<MapDisplay>();
		display.DrawNoiseMap(noiseMap);
	}

	void OnValidate()
	{
		if (mapWidth < 1)
		{
			mapWidth = 1;
		}
		if (mapHeight < 1)
		{
			mapHeight = 1;
		}
		if (lacunarity < 1)
		{
			lacunarity = 1;
		}
		if (octaves < 0)
		{
			octaves = 0;
		}
	}
}
