﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    private BoxCollider2D backgroundCollider;
    private float backgroundHorizontalLength;

	// Use this for initialization
	void Start ()
    {
        backgroundCollider = GetComponent<BoxCollider2D>();
        backgroundHorizontalLength = backgroundCollider.size.x * 3.0f;
	}
	
	// Update is called once per frame
	void Update ()
    {

		if(transform.position.x < -backgroundHorizontalLength)
        {
            RepositionBackground();
        }
	}

    private void RepositionBackground()
    {
        Vector2 backgroundOffset = new Vector2(backgroundHorizontalLength * 3.0f, 0);
        transform.position = (Vector2)transform.position + backgroundOffset;
    }
}
