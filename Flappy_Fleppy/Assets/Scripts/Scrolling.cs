using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {

    private Rigidbody2D rb2d;
    public ButtonHandler buttonAction;
    public PlayerController player;

	// Use this for initialization
	void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (buttonAction.startGame == true)
        {
            rb2d.velocity = new Vector2(player.scrollSpeed, 0);
        }

        if (player.playerDeath == true)
        {
            rb2d.velocity = Vector2.zero;
        }
	}
}
