using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerMenu : MonoBehaviour {
    public float moveSpeed;
    public float jumpForce;
    public int duration;
    private Rigidbody2D rgb;
    float moveCharacter;
    Animator anim;
	// Use this for initialization
	void Start () {
      //  StartCoroutine("Wait");
        rgb = GetComponent<Rigidbody2D>();
        
	}
	
	// Update is called once per frame
	void Update () {

       // anim.SetFloat("speed", moveSpeed);
        rgb.velocity = new Vector2(moveSpeed, rgb.velocity.y);
    }
    // StartCoroutine("Wait");


    IEnumerator Wait()
    {
        yield return new WaitForSeconds(4.0f);
    }
}
