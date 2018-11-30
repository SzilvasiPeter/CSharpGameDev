using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovement : MonoBehaviour {

    private float rotateSpeed = 0.5f;
    private float radius = -30.0f;

    private Vector3 sun;
    private Vector3 center;
    private float angle;

	// Use this for initialization
	void Start () {
        sun = GameObject.Find("Sun").transform.position;
        center = sun;
	}
	
	// Update is called once per frame
	void Update () {
        angle += rotateSpeed * Time.deltaTime;

        var offset = new Vector3(Mathf.Sin(angle), Mathf.Cos(angle)) * radius;
        transform.position = center + offset;
	}
}
