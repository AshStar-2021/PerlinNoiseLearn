using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerate : MonoBehaviour
{
	public int mapWidth;
	public int mapHeight;
	public float noiseScale = 10f;

	[Range(1, 100)]
	public int octaves;			//�ȣ���Ҫ����1
	[Range(0, 1)]
	public float persistance;	//�־öȣ���Ҫ����0��С��1
	[Range(1, 20)]
	public float lacunarity;    //��϶�ȣ�����Ƶ�ʣ���Ҫ����1
	
	public int seed;
	public Vector2 offset;

	//�Ƿ����ڱ༭�����Զ�����
	public bool autoUpdate = true;
	public void GenerateMap()
	{
		//��������
		float[,] noiseMap = Noise.GenerateNoiseMap(mapWidth, mapHeight, seed, noiseScale, octaves,persistance,lacunarity,offset);

		//��ʾ��Plane��
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
