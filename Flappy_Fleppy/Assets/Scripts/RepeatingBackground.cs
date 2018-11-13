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
        backgroundHorizontalLength = backgroundCollider.size.x;
	}
	
	// Update is called once per frame
	void Update ()
    {
        print((float)transform.position.x);
        print((float)backgroundHorizontalLength);

		if(transform.position.x < -backgroundHorizontalLength)
        {
            RepositionBackground();
        }
	}

    private void RepositionBackground()
    {
        Vector2 backgroundOffset = new Vector2(backgroundHorizontalLength * 2.0f, 0);
        transform.position = (Vector2)transform.position + backgroundOffset;
    }
}
