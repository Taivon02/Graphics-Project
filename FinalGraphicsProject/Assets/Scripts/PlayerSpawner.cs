using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour {
    public GameObject[] gobj;
    int i = 0;
    // Use this for initialization
    void Start () {
       // StartCoroutine("Wait");
        Spawn();
	}
	
	// Update is called once per frame
	void Update () {
       // Spawn();
	}
    void Spawn()
    {
        if (i <= gobj.Length)
        {
            if (i < gobj.Length)
            {
                Instantiate(gobj[i], transform.position, Quaternion.identity);
                Invoke("Spawn", 4.0f);

                i++;
                if (i == gobj.Length)
                {
                    i = 0;  
                }
                
            }
        }
            
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(4.0f);
    }
}
