using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PowerUp : MonoBehaviour {

    Score score;
    //  public Slider energyBar;
  //  float energyValue = 0;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            score = GameObject.Find("Main Camera").GetComponent<Score>();
            //energyValue += 10.0f;

            score.scoreIncrease(10);

            Destroy(this.gameObject);
        }
    }
    
}
