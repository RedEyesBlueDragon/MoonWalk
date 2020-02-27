using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
   
    void Update()
    {
        transform.Rotate(new Vector3(0,0,30) * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Meteor>() != null)
        {
            GameControl.instance.Scored();
        }
    }


}
