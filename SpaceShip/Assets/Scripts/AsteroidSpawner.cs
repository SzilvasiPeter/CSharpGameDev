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
        //asterClone.transform.position = Random.insideUnitCircle * 36;
        float angle = Random.Range(0f, 360f);
        float dist = Random.Range(1.2f, 3f);
        asterClone.transform.Rotate(0, 0, angle);
        asterClone.transform.Translate(dist, dist, 0);
        //Vector3 zTransform = new Vector3(0.0f, 0.0f, -1.0f);
        //asterClone.transform.position += zTransform;
    }

    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }
}
