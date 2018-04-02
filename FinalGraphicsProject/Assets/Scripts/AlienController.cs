using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienController : MonoBehaviour {

    [SerializeField] float speed = 5.0f;
    bool facingRight = true;
    private bool jump;
    Animator anim;

    bool grounded = false;
    [SerializeField] bool airControl = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    [SerializeField] LayerMask whatIsGround;
    [SerializeField] float jumpForce = 700f;



    // Use this for initialization
    void Awake() {
        groundCheck = transform.Find("GroundCheck");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate() {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", grounded);
        anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

        Vector3 pos = transform.position;
       
       

    }
    public void Move(float move, bool jump)
    {
        if (grounded || airControl)
        {
            float moveCharacter = Input.GetAxis("Horizontal");
            anim.SetFloat("speed", Mathf.Abs(moveCharacter));
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveCharacter * speed, GetComponent<Rigidbody2D>().velocity.y);
            if (moveCharacter > 0 && !facingRight)
            {
                Flip();
            }
            else if (moveCharacter < 0 && facingRight)
                Flip();
        }
        if(grounded && jump)
        {
            anim.SetBool("Ground", false);
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }
    
      
    }
   /* private void Update()
    {
        if(grounded && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Ground", false);
            
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
            
        }
    }*/
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
