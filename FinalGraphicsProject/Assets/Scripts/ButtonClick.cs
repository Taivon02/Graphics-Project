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
                break;
            case "Jungle":
                text.SetActive(false);
                other.SetActive(true);
                other2.SetActive(false);
                break;
            case "Kitchen":
                text.SetActive(false);
                other.SetActive(false);
                other2.SetActive(true);
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
