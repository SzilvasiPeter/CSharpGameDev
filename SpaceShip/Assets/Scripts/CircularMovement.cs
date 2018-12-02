using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class CircularMovement : MonoBehaviour {
    private float radius;
    private float rotateSpeed;

    private Transform sun;
    private Vector3 center;
    private float angle;

    // Use this for initialization
    void Start () {
        sun = GameObject.Find("Sun").transform;
        Vector3 myPostion = this.transform.position;
        center = sun.position;

        // Distance between Planets and Sun (times -1 for put the planets to the another side)
        radius = Vector3.Distance(sun.position, this.transform.position) * -1;

        // This 50 just some magic number, which looks okay
        // Distance is exponentially slow down the rotation
        rotateSpeed = 50 / (radius * radius);

        this.transform.position = Utils.ChangePosition(myPostion);
    }

    // Update is called once per frame
    void Update()
    {
        angle += rotateSpeed * Time.deltaTime;

        var offset = new Vector3(Mathf.Sin(angle), Mathf.Cos(angle)) * radius;
        transform.position = center + offset;
    }
}
