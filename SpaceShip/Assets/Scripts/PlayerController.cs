using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rbody;

    public List<GameObject> lives;

    //[SerializeField]
    //private ParticleSystem flares;

    [SerializeField]
    private GameObject fireball;

    [SerializeField]
    private GameObject explosion;

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
            rbody.AddTorque(125);
        } else if (turnRight)
        {
            rbody.AddTorque(-125);
        }

        if(lives.Count == 0)
        {
            Destroy(this.gameObject);
            GameObject explosionClone = Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(explosionClone, 1.0f);
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "asteroid")
        {
            Destroy(lives[0].gameObject);
            lives.Remove(lives[0]);
        }
    }
}
