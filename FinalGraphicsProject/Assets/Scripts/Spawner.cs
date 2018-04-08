using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] gobj;
   
  
        
   // Animator animator;
    public float minSpawn = 1.0f;
    public float maxSpawn = 2.0f;
    public float chances;
    public GameObject[] normalGround;
    public GameObject[] specialGround;
    float platformWidth;
    float oldSpawnPoint;
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
       
             Instantiate(gobj[Random.Range(0, gobj.Length)], transform.position, Quaternion.identity);
          Invoke("Spawn", Random.Range(2.0f, 3.0f));
        
       
        
    }
   
}
