using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour {

    private GameObject[] characterList;
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
                SceneManager.LoadScene("Space");
            //    break;

        //}
       
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
