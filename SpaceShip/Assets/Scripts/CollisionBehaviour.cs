using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour {

    [SerializeField]
    private GameObject explosion;

	void OnCollisionEnter2D(Collision2D collision)
    {
        // Destroying laser
        if (this.gameObject.tag == "laser" && collision.gameObject.tag == "asteroid")
        {
            Destroy(gameObject);
        }

        // Destroy asteroid
        if(this.gameObject.tag == "asteroid" && collision.gameObject.tag == "laser")
        {
            Destroy(gameObject);
            GameObject explosionClone = Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(explosionClone, 1.0f);
        }
    }
}
