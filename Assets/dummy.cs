using UnityEngine;
using System.Collections;

public class dummy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        collider = GetComponent<TerrainCollider>();
        terrData = collider.terrainData;
	}
    TerrainCollider collider;
    TerrainData terrData;
	
	// Update is called once per frame
	void Update () {
        float[,] data = new float[terrData.heightmapHeight, terrData.heightmapWidth];
        for (int x = 0; x < terrData.heightmapHeight; x++)
        {
            for (int y = 0; y < terrData.heightmapWidth; y++)
            {
                data[x, y] = Random.Range(0f,0.03f);
            }
        }
        terrData.SetHeights(0, 0, data);
	}
}
