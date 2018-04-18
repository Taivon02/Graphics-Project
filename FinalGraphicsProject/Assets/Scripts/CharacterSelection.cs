using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class CharacterSelection : MonoBehaviour {
    Rect windowRect;
    private GameObject[] characterList;

    public GameObject text;
    public GameObject other;
    public GameObject other2;
    public GameObject panel;
    private int index;

    public void ToggleLeft()
    {
        
        characterList[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = characterList.Length - 1;
        }

        characterList[index].SetActive(true);
    }
    public void ToggleRight()
    {
        characterList[index].SetActive(false);
        index++;
        if (index == characterList.Length)
        {
            index = 0;
        }

        characterList[index].SetActive(true);
    }
    public void Confirmbtn()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);
       
        if (text.activeSelf == false && other.activeSelf == false && other2.activeSelf == false) {

            panel.SetActive(true);
        }
        //Loading the scenes based on the active text above each platform selection
        else if(text.activeSelf == true) {
        
            SceneManager.LoadScene("Space");
        }
        else if(other.activeSelf == true)
        {
            SceneManager.LoadScene("Outside");
        }
        else if(other2.activeSelf == true)
        {
            SceneManager.LoadScene("Fantasy");
        }
                
       
    }
   
    // Use this for initialization
    void Start () {
        index = PlayerPrefs.GetInt("CharacterSelected");

        characterList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }

        foreach (GameObject go in characterList)
        {
            go.SetActive(false);
        }
        if (characterList[index])
        {
            characterList[index].SetActive(true);
        }
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void HidePanel()
    {
        panel.SetActive(false);
    }
}
