using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rbody;

    [SerializeField]
    private ParticleSystem flares;

	// Use this for initialization
	void Start () {
        rbody = this.gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        bool goForward = Input.GetKey(KeyCode.W);
        bool turnLeft = Input.GetKey(KeyCode.A);
        bool turnRight = Input.GetKey(KeyCode.D);

        if (goForward)
        {
            rbody.AddForce(this.transform.up * -2);
        } else if (turnLeft)
        {
            rbody.AddTorque(500);
        } else if (turnRight)
        {
            rbody.AddTorque(-500);
        }
    }
}
