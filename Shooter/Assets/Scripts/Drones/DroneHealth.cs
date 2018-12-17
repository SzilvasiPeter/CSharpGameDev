using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroneHealth : MonoBehaviour, IDestructable {
    [SerializeField]
    protected Image enemyHealth;

    [SerializeField]
    protected Timer timer;

    [SerializeField]
    protected bool isDead = false;

    //public GameObject explosion;

    // Update is called once per frame
    protected virtual void Update () {
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

    public virtual void DestroyDrone()
    {
        isDead = true;
        Destroy(gameObject, 0.5f);
        timer.increaseCounter();
    }

    public virtual void DestructionOccur()
    {
        enemyHealth.fillAmount -= 0.09f;
    }
}
