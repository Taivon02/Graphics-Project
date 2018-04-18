using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateParticle : MonoBehaviour {

    public ParticleSystem _psystem;
    GameObject alien;
    GameObject anim;
    private int index;
   void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected"); 
        alien = GameObject.Find("Character").transform.GetChild(index).gameObject;
            anim = GameObject.Find("Character").transform.GetChild(index).gameObject;
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _psystem.Play();
            alien.GetComponent<UserController>().enabled = false;
            alien.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            StartCoroutine("Wait");
        }

    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(4.0f);
        anim.GetComponent<Animator>().Play(alien.name +"Dead", 0);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("GameOver");
    }
    

}
