using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mete : MonoBehaviour
{
    int counbullet = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ship")
        {

            GameControl.instance.Die();
        }
        
        else
        {
            counbullet++;
        }
    }


    private void Update()
    {
        if(counbullet == 4)
        {
            Destroy(gameObject);
           
        }
    }

}
