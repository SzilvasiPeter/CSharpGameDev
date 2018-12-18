using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

    public GameObject bullet;
    public Transform spawnArea;
	
	// Update is called once per frame
	void Update () {

        if (!isLocalPlayer)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CmdShoot();
        }

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 300.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 20.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }

    [Command]
    void CmdShoot()
    {
        GameObject bulletClone = (GameObject)Instantiate(bullet, spawnArea.position, spawnArea.rotation);
        bulletClone.GetComponent<Rigidbody>().AddForce(spawnArea.transform.forward * 900.0f);
        NetworkServer.Spawn(bulletClone);
        Destroy(bulletClone, 2.0f);
    }

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
        //base.OnStartLocalPlayer();
    }

}
