using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceman : MonoBehaviour
{
    public bool isDead = false;
   
    private Rigidbody2D rb2d;

    public int garv = 1;
    


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        isDead = false;
    }

    
    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
            
            if(!isDead)
            {
                GameControl.instance.Die();
                isDead = true;
            }
            
        
    }

}
