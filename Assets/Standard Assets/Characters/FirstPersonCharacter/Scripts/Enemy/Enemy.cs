using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed;

	// Use this for initialization
	void Start ()
    {
        GameObject destination = GameObject.Find("Destination");
        Vector3 heading = destination.transform.position - transform.position;
        float distance = heading.magnitude;
        m_DirectionToDestination = heading / distance;
    }
	
	// Update is called once per frame
	void Update ()
    {
      //  SetDestination();

    }

    void SetDestination()
    {
        GameObject destination = GameObject.Find("Destination");
        Vector3 heading = destination.transform.position - transform.position;
        float distance = heading.magnitude;
        m_DirectionToDestination = heading / distance;
        m_DirectionToDestination.y = 0.0f;

        gameObject.GetComponent<Rigidbody>().velocity = m_DirectionToDestination * Speed;
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health < 0)
        {
            //kill enemy
            Destroy(gameObject);
        }
    }

    public float health;
    public Vector3 m_DirectionToDestination;
}
