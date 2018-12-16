using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public Image playerHealth;
    public Text deathText;

    private Timer timeCheck;

    void Start()
    {
        timeCheck = GameObject.Find("Timer").GetComponent<Timer>();
        
    }

    // Update is called once per frame
    void Update () {
        if (playerHealth.fillAmount <= 0.0f || timeCheck.timesUp == true)
        {
            GameObject objectSave = gameObject.transform.GetChild(0).gameObject;
            objectSave.transform.parent = null;
            Destroy(gameObject);
            deathText.text = "You have died!";
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "laser")
        {
            playerHealth.fillAmount -= 0.09f;
        }
    }
}
