using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D rBody;
	
	// Update is called once per frame
	void Update () {
        //print("working");
        PlayerInput();
        PlayerMovoment();
	}

    void PlayerInput()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rBody.AddForce(Vector2.up * 50);
        }
    }

    void PlayerMovoment(){
    	rBody.AddForce(Vector2.right * 20 * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision){
    	if(collision.gameObject.tag == "Danger"){
    		Destroy(rBody);
    	}
    }

    // Called before Start() function
    /*void Awake() {

    }*/
}
