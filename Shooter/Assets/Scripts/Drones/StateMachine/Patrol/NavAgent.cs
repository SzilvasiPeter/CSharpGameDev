using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAgent : MonoBehaviour {

    [SerializeField]
    private Transform[] wayPoints;
    private int destPoint = 0;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = false;

        GoToNextPoint();
	}

    void GoToNextPoint()
    {
        if(wayPoints.Length == 0)
        {
            return;
        }
        agent.destination = wayPoints[destPoint].position;

        destPoint = (destPoint + 1) % wayPoints.Length;
    }

    // Update is called once per frame
    void Update () {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GoToNextPoint();
        }
	}
}
