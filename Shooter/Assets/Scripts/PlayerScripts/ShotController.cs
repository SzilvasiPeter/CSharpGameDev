using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour {

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private Transform spawnAre;

    public int timer = 0;    

	// Use this for initialization
	void Update () {
        timer += 1;
        SpawnBullet();
	}

    void SpawnBullet()
    {
        if(Input.GetMouseButton(0) && timer >= 20)
        {
            GameObject bulletClone = Instantiate(bullet, spawnAre.position, spawnAre.rotation);

            bulletClone.GetComponent<Rigidbody>().AddForce(spawnAre.transform.up * -200);
            timer = 0;
            Destroy(bulletClone, 1.0f);
        }
    }
}
