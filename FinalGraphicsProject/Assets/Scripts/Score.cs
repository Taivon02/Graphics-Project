﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {
    int playerScore = 0; 
    int highScore = 0; 
    Animator anim;
   public Camera cam;
  //  Vector2 pos = new Vector2(20, 10);
   // Vector2 size = new Vector2(200, 16);
    public Text highScoreText;
    public Text scoreText;

    private void Start()
    {
        if(cam == null)
        {
            cam = Camera.main;
        }
        playerScore = 0;
        scoreText.text = "Score:\n\t" + playerScore.ToString();
        highScore = PlayerPrefs.GetInt("High Score");
        highScoreText.text = "High Score:\n\t" + highScore.ToString();
        
    }
    // Update is called once per frame
    void Update () {
        
        scoreText.text = "Score:\n\t" + playerScore.ToString();
        if (playerScore > highScore)
        {
            highScore = playerScore;

           
            PlayerPrefs.SetInt("High Score", highScore);
        }
       
    }
    private void FixedUpdate()
    {
        playerScore += (int)Camera.current.transform.position.x;
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