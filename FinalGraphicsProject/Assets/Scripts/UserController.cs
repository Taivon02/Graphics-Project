using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserController : MonoBehaviour {
    private AlienController character;
   private ActivateParticle particle;
    bool canControl;
    bool movement;
   // Score score;
   //public Slider energyBar;
 
   // public GameObject par;
    private Animator anim;
    private bool jump;

    private void Awake()
    {
        character = GetComponent<AlienController>();
    }
    // Use this for initialization
    void Start () {
        canControl = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
            jump = true;
        

    }
   private void FixedUpdate()
    {
        if (canControl)
        {
            character.Move(1, jump, true);
        }
        else
        {
            character.Move(0, false, false);
        }
        jump = false;

    }
    private void LateUpdate()
    {
        if (canControl)
        {
            character.Move(1, jump, true);
        }
        else
        {
            character.Move(0, false, false);
        }
        jump = false;
    }
    public void toggleControl(bool toggle)
    {
        canControl = toggle;
    }
    public void isMoving(bool moving)
    {
        movement = moving;
    }
}
