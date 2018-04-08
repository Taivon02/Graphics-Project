using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;


public class CharacterSelection : MonoBehaviour {
    Rect windowRect;
    private GameObject[] characterList;

    public GameObject text;
    public GameObject other;
    public GameObject other2;

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
        //  switch (this.gameObject.name)
        //{
        //  case "Space":
        if (text.activeSelf == false && other.activeSelf == false && other2.activeSelf == false) { 
            // OnGUI();
            EditorUtility.DisplayDialog("Error", "Please Choose a Platform", "OK");
        }
        else if(text.activeSelf == true) {
        
            SceneManager.LoadScene("Space");
        }
        else if(other.activeSelf == true)
        {
            //SceneManager.LoadScene("Jungle");
        }
        else if(other2.activeSelf == true)
        {
            //SceneManager.LoadScene("Kitchen");
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
}
