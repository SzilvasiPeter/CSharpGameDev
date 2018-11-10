using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D rBody;
    public ButtonHandler buttonAction;
    public TextBehavior textScript;
    public bool playerDeath = false;
    public bool playerWin = false;

    void Start(){
        rBody.bodyType = RigidbodyType2D.Kinematic;
    }
	
	// Update is called once per frame
	void Update () {
        if(buttonAction.startGame == true){
            rBody.bodyType = RigidbodyType2D.Dynamic;
            PlayerInput();
            PlayerMovoment();
        }

        if(playerWin == true){
            rBody.bodyType = RigidbodyType2D.Kinematic;
        }
        
	}

    void PlayerInput()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rBody.AddForce(Vector2.up * 50);
        }
    }

    void PlayerMovoment(){
    	rBody.AddForce(Vector2.right * 40 * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision){
    	if(collision.gameObject.tag == "Danger"){
            playerDeath = true;
    		Destroy(rBody);
    	} else if(collision.gameObject.tag == "Victory"){
            playerWin = true;
        }
    }

    // Called before Start() function
    /*void Awake() {

    }*/
}
