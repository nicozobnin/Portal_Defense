﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	
        
	}

    public void TakeDamage(float damage)
    {

        health -= damage;
        if(damage < 0)
        {
            //kill enemy
            Destroy(gameObject);
        }

    }

    public float health;
}
