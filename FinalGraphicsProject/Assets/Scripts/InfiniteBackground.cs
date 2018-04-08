using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteBackground : MonoBehaviour {
    private float speed = .1f;
   // AlienController alien;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 offset = new Vector2(Time.time*speed, 0);

        GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
