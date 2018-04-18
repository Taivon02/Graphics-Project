using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Start":
                SceneManager.LoadScene("Selection");
                break;
            case "Quit":
                Application.Quit();
                break;
            case "Main Menu":
                SceneManager.LoadScene("Menu");
                break;
        }
     
    }
	
}
