using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] gobj;
    public float minSpawn = 1.0f;
    public float maxSpawn = 2.0f;
	// Use this for initialization
	void Start () {
        Spawn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Spawn()
    {
        Instantiate(gobj[Random.Range(0, gobj.Length)], transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(minSpawn, maxSpawn));
    }
}
