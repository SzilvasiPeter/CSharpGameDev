using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour {

    public GameObject columnBottomSpawns;
    public GameObject columnTopSpawns;
    public Transform playerPos;

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
        float spacing = totalTime;
        float i = UnityEngine.Random.Range(-4.0f, 4.0f);

        //pos.position = new Vector3(13.0f + spacing, -9.0f + i, -3.0f);
        Vector3 posB = new Vector3(17.0f * spacing, (-9.0f + i), -3.0f);
        GameObject columnBClone = Instantiate(columnBottomSpawns, playerPos.position, playerPos.rotation);
        columnBClone.transform.position = posB;
        //columnBClone.transform.position += Vector3.left * Time.deltaTime;
        //columnBClone.transform.position = posB;

        //pos.position = new Vector3(13.0f + spacing, 13.0f + i, -3.0f);
        Vector3 posT = new Vector3(17.0f * spacing, (13.0f + i), -3.0f);
        GameObject columnTClone = Instantiate(columnTopSpawns);
        columnTClone.transform.position = posT;
        //columnTClone.transform.position += Vector3.left * Time.deltaTime;
        //columnTClone.transform.position = posT;W
        currentTime = 0;
    }
}