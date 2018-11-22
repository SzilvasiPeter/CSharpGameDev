using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {

    public GameObject[] asteroidSpawns;
    float maxTime = 5;
    float minTime = 2;

    private float time;
    private float spawnTime;

	// Use this for initialization
	void Start () {
        SetRandomTime();
        time = minTime;
	}

    void FixedUpdate()
    {
        time += Time.deltaTime;
        while(time > spawnTime)
        {
            GenerateAsters();
        }
    }

    void GenerateAsters()
    {
        time = 0;
        int i = Random.Range(0, asteroidSpawns.Length);
        GameObject asterClone = Instantiate(asteroidSpawns[i]);
        asterClone.transform.position = Random.insideUnitCircle * 5;
        Vector3 zTransform = new Vector3(0.0f, 0.0f, -1.0f);
        asterClone.transform.position += zTransform;
    }

    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }
}
