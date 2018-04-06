using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserController : MonoBehaviour {
    private AlienController character;
 
   
   // Score score;
   //public Slider energyBar;
 
   // public GameObject par;
    //private Animator anim;
    private bool jump;

    private void Awake()
    {
        character = GetComponent<AlienController>();
    }
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
            jump = true;
        

    }
   private void FixedUpdate()
    {
     
            character.Move(1, jump, true);
        jump = false;

    }
 
}
