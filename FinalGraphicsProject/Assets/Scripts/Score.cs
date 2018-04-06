using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {
    int playerScore = 0; 
    int highScore = 0;
    public Transform player;
    Animator anim;
   public Camera cam;

    //  Vector2 pos = new Vector2(20, 10);
    // Vector2 size = new Vector2(200, 16);
  
    public Text highScoreText;
    public Text scoreText;
    private int points = 1;
    private float playerStartPoint;

    private void Start()
    {
       
        playerScore = 0;
        scoreText.text = "Score:\n\t" + playerScore.ToString();
        highScore = PlayerPrefs.GetInt("High Score");
        highScoreText.text = "High Score:\n\t" + highScore.ToString();
        
    }
    // Update is called once per frame
    void Update () {

        playerScore += (int)Time.deltaTime;
        
        scoreText.text = "Score:\n\t" + playerScore.ToString();
        if (playerScore > highScore)
        {
            highScore = playerScore;

           
            PlayerPrefs.SetInt("High Score", highScore);
        }
       
    }
    private void LateUpdate()
    {
        playerStartPoint = player.transform.position.x;
          //  playerScore += (int)points * 100;
        
    }

    public void scoreIncrease(int amount)
    {
        playerScore += amount;
    }
    public void updateScore()
    {
        if(anim.GetFloat("speed") > 0.01)
        {
            playerScore += 100;
        }
    }
    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)playerScore);
        
    }
    /*private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Score: " + (int)playerScore);
       GUI.Label(new Rect(20, 20, 100, 30), "High Score: " + (int)playerScore);

    }*/
   
   
}
