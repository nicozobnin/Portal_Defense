using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        m_Health = 100;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (m_Health <= 0)
        {
            Destroy(gameObject);

            // GAME OVER
        }
	}

    public void TakeDamage(float damage)
    {
        m_Health -= damage;
    }

    float m_Health;
}
