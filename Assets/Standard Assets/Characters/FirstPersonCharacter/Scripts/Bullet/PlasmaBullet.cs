﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaBullet : BulletClass
{

	// Use this for initialization
	void Start ()
    {
        Damage = 5;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public override void applyDamage()
    {
        base.applyDamage();
    }
}
