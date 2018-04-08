using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOver : MonoBehaviour {

    int score = 0;
    public Text text;
	// Use this for initialization
	void Start () {
        score = PlayerPrefs.GetInt("Score");
        text.text = "Score:\t" + score.ToString(); 
	}
    

    public void restartClick()
    {
        SceneManager.LoadScene("Space");
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
