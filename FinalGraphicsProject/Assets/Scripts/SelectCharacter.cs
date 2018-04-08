﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour {

    private GameObject[] characterList;
	// Use this for initialization
	void Start () {
        characterList = new GameObject[transform.childCount];

        for(int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }

        foreach(GameObject go in characterList)
        {
            go.SetActive(false);
        }
        if (characterList[0])
        {
            characterList[0].SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}