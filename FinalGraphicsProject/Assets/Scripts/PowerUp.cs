using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PowerUp : MonoBehaviour {

    Score score;
     Slider energyBar;
    GameObject platformSpawner;
    GameObject platformSpawner1;
    GameObject platformSpawner2;
    GameObject platformGenerator;
    //  float energyValue = 0;
    private void Start()
    {
        energyBar = GameObject.Find("EnergyBar").GetComponent<Slider>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            score = GameObject.Find("Main Camera").GetComponent<Score>();
            //energyValue += 10.0f;
            
            score.scoreIncrease(10);
            if(energyBar.value < 100)
            energyBar.value += 5;
            else if(energyBar.value == 100)
            {
               /* platformGenerator.SetActive(true);
                platformSpawner.GetComponent<Spawner>().enabled = false;
                platformSpawner1.GetComponent<Spawner>().enabled = false;
                platformSpawner2.GetComponent<Spawner>().enabled = false;*/
            }

            Destroy(this.gameObject);
        }
        
    }
    
}
