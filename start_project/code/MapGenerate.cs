using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerate : MonoBehaviour
{
	public int mapWidth;
	public int mapHeight;
	public float noiseScale = 10f;

	//是否开启在编辑器中自动更新
	public bool autoUpdate = true;
	public void GenerateMap()
	{
		//生成噪声
		float[,] noiseMap = Noise.GenerateNoiseMap(mapWidth, mapHeight,noiseScale);

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
	}
}
