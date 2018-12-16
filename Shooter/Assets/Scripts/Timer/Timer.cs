using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private Text timerText;
    public bool timesUp = false;
    private float deplete = 0.5f;
    private float currentTime = 30.0f;

    public DroneStationaryHealth[] stationaryDrones;
    public PatrollingDroneHealth[] patrollingDrones;

    // Use this for initialization
    void Start () {
        timerText = gameObject.GetComponent<Text>();
        timerText.text = currentTime.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        if (currentTime <= 0)
        {
            currentTime = 0.0f;
            timesUp = true;
        }

        if (stationaryDrones.Length != 0 && patrollingDrones.Length != 0)
        {
            currentTime -= deplete * Time.deltaTime;
        }

        timerText.text = currentTime.ToString();

    }
}
