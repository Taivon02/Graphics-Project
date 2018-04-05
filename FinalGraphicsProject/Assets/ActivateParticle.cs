using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateParticle : MonoBehaviour {

    public ParticleSystem _psystem;
    GameObject alien;
    GameObject anim;
    Rigidbody2D rg;
   void Start()
    {
        alien = GameObject.Find("Character");
        anim = GameObject.Find("Character");
    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        _psystem.Play();
        alien.GetComponent<UserController>().enabled = false;
        alien.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        StartCoroutine("Wait");

    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(4);
        anim.GetComponent<Animator>().Play("Dead", 0);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("GameOver");
    }

}
