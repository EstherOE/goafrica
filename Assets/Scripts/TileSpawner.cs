using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public float zSpawn = 0;
    public float tileLength = 15.5f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTile(0);
        SpawnTile(2);
        SpawnTile(4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTile(int titleIndex)
    {

        Instantiate(prefabs[titleIndex], transform.forward * zSpawn, transform.rotation);
        zSpawn += tileLength;
    }
}
