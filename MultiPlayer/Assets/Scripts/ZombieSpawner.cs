using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ZombieSpawner : NetworkBehaviour {

    public int numberOfZombies;
    public GameObject zombie;

    public override void OnStartServer()
    {
        SpawnZombies();
    }
	
	// Update is called once per frame
	void Update () {
        int zombieInScene = GameObject.FindGameObjectsWithTag("zombie").Length;

        if(zombieInScene == 0)
        {
            SpawnZombies();
        }
	}
    
    void SpawnZombies()
    {
        for(int i=0; i < numberOfZombies; i++)
        {
            var spawnPosition = new Vector3(Random.Range(-8.0f, 8.0f), 0.0f, Random.Range(-8.0f, 8.0f));

            var spawnRot = Quaternion.Euler(0.0f, Random.Range(0, 180), 0.0f);
            var zombieClone = (GameObject)Instantiate(zombie, spawnPosition, spawnRot);

            NetworkServer.Spawn(zombieClone);
        }
    }
}
