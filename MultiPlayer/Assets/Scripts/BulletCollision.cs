using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "zombie")
        {
            var hit = collision.gameObject;
            var zombieHit = hit.gameObject.GetComponent<ZombieMovoment>();
            if(zombieHit != null)
            {
                Destroy(hit);
            }
        }
        Destroy(this.gameObject);
    }
}
