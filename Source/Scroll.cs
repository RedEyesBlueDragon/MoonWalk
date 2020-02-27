﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public float increase = 0;

    public float fireRate = 20f;
    private float nextFire = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(GameControl.instance.scrollSpeed, 0);
        GameControl.instance.Score = -90;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl.instance.gameOver == true)
        {
            rb2d.velocity = Vector2.zero;
        }

        if (GameControl.instance.gameOver == false && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameControl.instance.scrollSpeed = GameControl.instance.scrollSpeed + increase;
            rb2d.velocity = new Vector2(GameControl.instance.scrollSpeed, 0);
        }
    }
}
