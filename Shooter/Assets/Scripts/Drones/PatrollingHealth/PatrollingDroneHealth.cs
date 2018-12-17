using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatrollingDroneHealth : DroneHealth {

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    public override void DestroyDrone()
    {
        base.DestroyDrone();
    }

    public override void DestructionOccur()
    {
        base.DestructionOccur();
    }
}
