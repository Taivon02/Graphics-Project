using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour {

    public GameObject[] gobj;
    public float minSpawn = 1.0f;
    public float maxSpawn = 2.0f;
    private void Start()
    {
        Spawn();
    }
    // Update is called once per frame
    void Update () {
		
	}
    void Spawn()
    {
        Instantiate(gobj[Random.Range(0, gobj.Length - 1)], transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(minSpawn,maxSpawn));
    }
}
