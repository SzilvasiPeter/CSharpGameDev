using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform playPos;
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.position = new Vector3(playPos.position.x + 10, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
	}
}
