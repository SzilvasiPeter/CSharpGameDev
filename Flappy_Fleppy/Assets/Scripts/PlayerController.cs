using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D rBody;
    public ButtonHandler buttonAction;
    public TextBehavior textScript;
    public bool playerDeath = false;
    public bool playerWin = false;
    public bool isGameOver = false;
    public float scrollSpeed = -5.0f;
    public int score = 0;
    private float heldTime = 0.0f;

    public static PlayerController instance;

    public Text scoreText;
    public GameObject gameOverText;

    void Start(){
        rBody.bodyType = RigidbodyType2D.Kinematic;
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if(buttonAction.startGame == true){
            rBody.bodyType = RigidbodyType2D.Dynamic;
            PlayerInput();
            PlayerMovoment();
            heldTime += Time.deltaTime;
            if (heldTime >= 1)
            {
                score += (int)heldTime;
                scoreText.text = "Score: " + score;
                heldTime -= (int)heldTime;
            }
        }

        if(playerWin == true){
            rBody.bodyType = RigidbodyType2D.Kinematic;
        }

        if((playerDeath == true || playerWin == true) && Input.GetMouseButtonDown(0))
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Destroy(gameObject);
        }

        if(Time.deltaTime % 50.0f == 0)
        {
            score++;
        }
        
	}

    public void Die()
    {
        isGameOver = true;
        gameOverText.SetActive(true);
    }

    void PlayerInput()
    {
        // Input for PC
        if(Input.GetKey(KeyCode.Space))
        {
            rBody.AddForce(Vector2.up * 50);
        }
        // original namespace: com.Company.ProductName
        // Input for mobile phone (android)
        /*if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
            rBody.AddForce(Vector2.up * 50);
        }*/
    }

    void PlayerMovoment(){
    	rBody.AddForce(Vector2.right * 10.0f * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision){
    	if(collision.gameObject.tag == "Danger"){
            playerDeath = true;
    		Destroy(rBody);
    	} else if(collision.gameObject.tag == "Victory"){
            playerWin = true;
        }
    }

    // Called before Start() function
    /*void Awake()
    {
        
    }*/
}
