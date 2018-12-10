using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour {

    public GameObject columnBottomSpawns;
    public GameObject columnTopSpawns;
    //public Transform pos;

    private float currentTime = 0;
    private float totalTime = 0;

    private float spawnTime = 2.0f;

    // Use this for initialization
    void Start()
    {
        currentTime = 0;
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        totalTime += Time.deltaTime;
        while (currentTime > spawnTime)
        {
            GenerateColumns();
        }
    }

    void GenerateColumns()
    {
        float spacing = totalTime * 11.5f + 12.0f;
        float i = UnityEngine.Random.Range(-4.0f, 4.0f);

        //pos.position = new Vector3(13.0f + spacing, -9.0f + i, -3.0f);
        Vector3 posb = new Vector3(13.0f + spacing, -9.0f + i, -3.0f);
        Instantiate(columnBottomSpawns, posb, Quaternion.identity);

        //pos.position = new Vector3(13.0f + spacing, 13.0f + i, -3.0f);
        Vector3 post = new Vector3(13.0f + spacing, 13.0f + i, -3.0f);
        Instantiate(columnTopSpawns, post, Quaternion.identity);
        currentTime = 0;
    }
}
