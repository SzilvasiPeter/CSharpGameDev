using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private Text timerText;
    public bool timesUp = false;
    private float deplete = 0.5f;
    private float currentTime = 30.0f;
    public bool win = false;
    public int counter = 0;

    // Use this for initialization
    void Start () {
        timerText = gameObject.GetComponent<Text>();
        timerText.text = currentTime.ToString();
	}

    // Update is called once per frame
    void Update()
    {
        if (currentTime <= 0)
        {
            currentTime = 0.0f;
            timesUp = true;
        }

        if (counter != 4)
        {
            currentTime -= deplete * Time.deltaTime;
        }
        else
        {
            win = true;
        }


        timerText.text = currentTime.ToString();

    }

    public void increaseCounter()
    {
        counter++;
    }

}
