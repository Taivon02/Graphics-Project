using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
   public Transform player;
    private int index;
    private void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");
        player = GameObject.Find("Character").transform.GetChild(index);
    }
    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(player.position.x + 6, 0, -10);
	}
}
