using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovoment : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        Transform playerPos = GameObject.FindGameObjectWithTag("player").transform;
        transform.LookAt(playerPos);

        GetComponent<Rigidbody>().AddForce(transform.forward * 500.0f * Time.deltaTime);
	}
}
