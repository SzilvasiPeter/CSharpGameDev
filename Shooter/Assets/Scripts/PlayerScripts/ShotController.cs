using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour {

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private Transform spawnArea;

    public int timer = 0;

    public Animation animClip;

    bool canShoot = true;

	// Use this for initialization
	void Update () {
        timer += 1;
        SpawnBullet();
	}

    void SpawnBullet()
    {
        if(Input.GetMouseButton(0) && timer >= 20)
        {
            GameObject bulletClone = Instantiate(bullet, spawnArea.position, spawnArea.rotation);
            bulletClone.GetComponent<Rigidbody>().AddForce(spawnArea.transform.up * -200);
            canShoot = false;
            StartCoroutine("RecoilAnim");
            timer = 0;
            Destroy(bulletClone, 1.0f);
        }
    }

    IEnumerator RecoilAnim()
    {
        animClip.Play("Gun_Recoil");
        yield return new WaitForSeconds(animClip.clip.length);
        canShoot = true;
    }
}
