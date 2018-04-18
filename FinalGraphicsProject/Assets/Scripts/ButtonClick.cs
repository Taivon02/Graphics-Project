using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour {
   public GameObject text;
    public GameObject other;
    public GameObject other2;
    
    public void buttonClicked()
    {
        switch (gameObject.name)
        {
            case "Space":
                text.SetActive(true);
                other.SetActive(false);
                other2.SetActive(false);
                if (PlayerPrefs.HasKey("Scene Selection"))
                {
                    PlayerPrefs.DeleteKey("Scene Selection");
                }
                PlayerPrefs.SetString("Scene Selection", "Space");
                break;
            case "Outside":
                text.SetActive(false);
                other.SetActive(true);
                other2.SetActive(false);
                if (PlayerPrefs.HasKey("Scene Selection"))
                {
                    PlayerPrefs.DeleteKey("Scene Selection");
                }
                PlayerPrefs.SetString("Scene Selection", "Outside");
                break;
            case "Fantasy":
                text.SetActive(false);
                other.SetActive(false);
                other2.SetActive(true);
                if (PlayerPrefs.HasKey("Scene Selection"))
                {
                    PlayerPrefs.DeleteKey("Scene Selection");
                }
                PlayerPrefs.SetString("Scene Selection", "Fantasy");
                break;
        }
    
       
    }
  
    // Use this for initialization
    void Start () {
     
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
