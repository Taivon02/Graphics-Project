using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] gobj;
  
    UserController user;
  //  AlienController alien;
   // Animator animator;
    public float minSpawn = 1.0f;
    public float maxSpawn = 2.0f;
    public float chances = .05f;
    public GameObject[] normalGround;
    public GameObject[] specialGround;
    
	// Use this for initialization
	void Start () {
        Spawn();
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void Spawn()
    {
        if (Random.Range(0, 1.0f) > chances)
        {
            gobj = normalGround;
        }
        else
        {
            gobj = specialGround;
        }
        
        
            Instantiate(gobj[Random.Range(0, gobj.Length - 1)], transform.position, Quaternion.identity);
            Invoke("Spawn", Random.Range(2.0f, 3.0f));
        
           
        
    }
}
