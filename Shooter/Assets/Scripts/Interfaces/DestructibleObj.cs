using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleObj : MonoBehaviour, IDestructable {

    private int hitCounter = 0;

    public void DestructionOccur()
    {
        hitCounter += 1;
        if(hitCounter >= 3)
        {
            Destroy(gameObject);
        }
    }
}
