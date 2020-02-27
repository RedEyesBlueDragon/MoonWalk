using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeat : MonoBehaviour
{

    private float groundHorizantalLength;

    // Start is called before the first frame update
    void Start()
    {
        groundHorizantalLength = 72.05f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundHorizantalLength)
        {
            RepositionBackground();
        }
    }

    void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(groundHorizantalLength * 1.5f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}