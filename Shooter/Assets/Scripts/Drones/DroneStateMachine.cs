using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DroneStateMachine : MonoBehaviour {

    enum States
    {
        PATROL,
        ATTACK
    };

    States currentState = States.PATROL;

    private NavAgent dronePatrolling;

    private AttackPlayer droneAttacking;
    private NavMeshAgent thisNavMesh;

	// Use this for initialization
	void Start () {
        dronePatrolling = GetComponent<NavAgent>();
        droneAttacking = GetComponent<AttackPlayer>();
        thisNavMesh = GetComponent<NavMeshAgent>();
        ChangeState(States.PATROL);
	}
	
	// Update is called once per frame
	void Update () {
		if(droneAttacking.playerDetected == true)
        {
            ChangeState(States.ATTACK);
        }

        if(droneAttacking.playerDetected == false)
        {
            ChangeState(States.PATROL);        }
	}

    void ChangeState(States stateValue)
    {
        if (currentState == stateValue)
        {
            return;
        }

        switch (stateValue)
        {
            case States.PATROL:
                {
                    dronePatrolling.enabled = true;
                    thisNavMesh.enabled = true;
                    break;
                }
            case States.ATTACK:
                {
                    dronePatrolling.enabled = false;
                    thisNavMesh.enabled = false;
                    break;
                }
            default:
                {
                    return;
                }
        }
        currentState = stateValue;
    }
}
