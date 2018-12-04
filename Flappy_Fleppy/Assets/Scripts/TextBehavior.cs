using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBehavior : MonoBehaviour {

	public bool gameBegan = false;
	public ButtonHandler buttonAction;
	public PlayerController player;
	public GameObject startButton;
	public GameObject restartButton;

    // Update is called once per frame
    void Update () {
		if(buttonAction.startGame == true){
			PlayerStatus();
		}

		if(player.playerDeath == true){
			DeathText();
		}

		if(player.playerWin == true){
			WinText();
		}
	}

	void PlayerStatus(){
		Text displayText = this.gameObject.GetComponent<Text>();
		displayText.text = "";
		startButton.SetActive(false);
	}

	void DeathText(){
		Text displayText = this.gameObject.GetComponent<Text>();
		displayText.text = "You have died. Click to try again.";
		restartButton.SetActive(true);
	}

	void WinText(){
		Text displayText = this.gameObject.GetComponent<Text>();
		displayText.text = "You win. Click to play again!";
		restartButton.SetActive(true);
	}
}
