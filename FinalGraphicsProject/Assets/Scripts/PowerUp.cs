using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PowerUp : MonoBehaviour {

    Score score;
     Slider energyBar;
    
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
             if(energyBar.value == 100)
            {
                score.scoreIncrease(3000);
                energyBar.value = 0;
            }

            Destroy(this.gameObject);
        }
        
    }
   
    
}
