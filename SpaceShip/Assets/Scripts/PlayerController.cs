using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rbody;

    //[SerializeField]
    //private ParticleSystem flares;

    [SerializeField]
    private GameObject fireball;

	// Use this for initialization
	void Start () {
        rbody = this.gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        fireLaser();
        bool goForward = Input.GetKey(KeyCode.W);
        bool turnLeft = Input.GetKey(KeyCode.A);
        bool turnRight = Input.GetKey(KeyCode.D);

        if (goForward)
        {
            rbody.AddForce(this.transform.up * -1.5f);
        } else if (turnLeft)
        {
            rbody.AddTorque(500);
        } else if (turnRight)
        {
            rbody.AddTorque(-500);
        }
    }

    void fireLaser()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform spawnArea = gameObject.transform.GetChild(0).transform;
            GameObject laserClone = Instantiate(fireball, spawnArea.position, spawnArea.rotation);

            laserClone.GetComponent<Rigidbody2D>().AddForce(this.transform.up * -700);

            Destroy(laserClone, 2.0f);
        }
    }
}
