using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {
    int playerScore = 0; 
    int highScore = 0;
    public Transform player;
    Slider energyBar;
    Animator anim;

    //  Vector2 pos = new Vector2(20, 10);
    // Vector2 size = new Vector2(200, 16);
  
    public Text highScoreText;
    public Text scoreText;
    

    public float distance;
   


    void Awake()
    {
        distance = Vector3.Distance(player.position, transform.position);

    }

    void score()
    {
        distance = Vector3.Distance(player.position, transform.position);
       playerScore += (int)distance;
      
    }


    private void Start()
    {
       
        playerScore = 0;
        transform.position = player.position;
        distance = 0;
        scoreText.text = "Score:\n\t" + playerScore.ToString();
        highScore = PlayerPrefs.GetInt("High Score");
        highScoreText.text = "High Score:\n\t" + highScore.ToString();
        
    }
    // Update is called once per frame
    void Update () {
        score();
        scoreText.text = "Score:\n\t" + playerScore.ToString();
        if (playerScore > highScore)
        {
            highScore = playerScore;

           
            PlayerPrefs.SetInt("High Score", highScore);
        }
       
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
