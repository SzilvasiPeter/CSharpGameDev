using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour {

	public Button startButton;
	public Button restartButton;
	public bool startGame = false;
	public bool restartGame = false;

	// Use this for initialization
	void Start () {
		Button sButton = startButton.GetComponent<Button>();
		sButton.onClick.AddListener(StartGame);

		Button rButton = restartButton.GetComponent<Button>();
		rButton.onClick.AddListener(Restart);
	}
	
	void StartGame(){
		startGame = true;
	}

	public void Restart(){
		SceneManager.LoadScene("SampleScene");
	}
}
