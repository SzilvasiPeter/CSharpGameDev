﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground1 : MonoBehaviour {

    private BoxCollider2D backgroundCollider;
    private float backgroundHorizontalLength;
    //public Transform playerPos;

	// Use this for initialization
	void Start ()
    {
        backgroundCollider = GetComponent<BoxCollider2D>();
        backgroundHorizontalLength = backgroundCollider.size.x * 3.0f;
	}
	
	// Update is called once per frame
	void Update ()
    {

		if(transform.position.x < -backgroundHorizontalLength / 1.8f)
        {
            RepositionBackground();
        }
	}

    private void RepositionBackground()
    {
        Vector3 backgroundOffset = new Vector3(backgroundHorizontalLength * 3.0f, 0, 0);
        transform.position = (Vector3)transform.position + backgroundOffset;
    }
}
