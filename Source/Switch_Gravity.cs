using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Switch_Gravity : MonoBehaviour
{
 
    private Rigidbody2D rb;

    private bool top;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //!IsPointerOverUIObject()
        //EventSystem.current.IsPointerOverGameObject();
        
       if (!GameControl.instance.gameOver && Input.GetMouseButtonDown(0))
        {
            rb.gravityScale *= -1;
            //Rotation();
        }
        
        
    }

    public void ChangeGravity()
    {
        rb.gravityScale *= -1;
    }
        


    private bool IsPointerOverUIObject()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }


    void Rotation()
    {
        if(top == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 180f);
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }

        top = !top;
    }

}
