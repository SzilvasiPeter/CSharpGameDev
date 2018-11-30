using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CircularMovement : MonoBehaviour {

    private float radius;
    private float rotateSpeed;
    private double randomRange;

    private Transform sun;
    private Vector3 center;
    private float angle;

    //Function to get a random number 
    private static readonly System.Random random = new System.Random();
    private static readonly object syncLock = new object();
    public static int RandomNumber(int min, int max)
    {
        lock (syncLock)
        { // synchronize
            return random.Next(min, max);
        }
    }

    // Use this for initialization
    void Start () {
        sun = GameObject.Find("Sun").transform;
        center = sun.position;

        // Distance between Planets and Sun (times -1 for put the planets to the another side)
        radius = Vector3.Distance(sun.position, this.transform.position) * -1;

        // This 50 just some magic number, which looks okay
        // Distance is exponentially slow down the rotation
        rotateSpeed = 50 / (radius * radius);
        print(rotateSpeed);

        randomRange = RandomNumber(-1, 1);
        Console.WriteLine(randomRange);
    }
	
	// Update is called once per frame
	void Update () {
        angle += rotateSpeed * Time.deltaTime;

        var offset = new Vector3(Mathf.Sin(angle), Mathf.Cos(angle)) * radius;
        transform.position = center + offset;
	}
}
