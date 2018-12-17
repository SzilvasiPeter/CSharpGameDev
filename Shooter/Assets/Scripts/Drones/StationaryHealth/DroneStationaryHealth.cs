using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroneStationaryHealth : MonoBehaviour {

    public Image enemyHealth;
    public Timer timer;
    private bool isDead = false;

    //public GameObject explosion;

    // Update is called once per frame
    void Update () {
        if (enemyHealth.fillAmount <= 0)
        {
            //GameObject explosionClone = Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            //Destroy(explosion, 0.5f);
            if (!isDead)
            {
                DestroyDrone();
            }
        }
	}

    void DestroyDrone()
    {
        isDead = true;
        Destroy(gameObject, 0.5f);
        timer.increaseCounter();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            enemyHealth.fillAmount -= 0.09f;
        }
    }
}
