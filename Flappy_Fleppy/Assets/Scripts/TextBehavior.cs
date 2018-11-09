using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBehavior : MonoBehaviour {

	public bool gameBegan = false;
	public PlayerController deathHappened;
	
	// Update is called once per frame
	void Update () {
		if(gameBegan == true){
			PlayerStatus();
		}

		if(deathHappened.playerDeath){
			DeathText();
		}
	}

	public void ClickToStart(){
		gameBegan = true;
		GameObject startButton = GameObject.Find("StartButton");
		startButton.SetActive(false);
	}

	void PlayerStatus(){
		Text displayText = this.gameObject.GetComponent<Text>();
		displayText.text = "";
	}

	void DeathText(){
		Text displayText = this.gameObject.GetComponent<Text>();
		displayText.text = "You have died. Click to try again.";
	}
}
