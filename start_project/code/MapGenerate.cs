using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerate : MonoBehaviour
{
	public int mapWidth;
	public int mapHeight;
	public float noiseScale = 10f;

	//�Ƿ����ڱ༭�����Զ�����
	public bool autoUpdate = true;
	public void GenerateMap()
	{
		//��������
		float[,] noiseMap = Noise.GenerateNoiseMap(mapWidth, mapHeight,noiseScale);

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
	}
}
