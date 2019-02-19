using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnDelay;

	// Use this for initialization
	void Start ()
    {
        m_SpawnTimer = SpawnDelay;
        m_CanSpawn = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (m_CanSpawn == false)
        {
            m_SpawnTimer -= Time.fixedDeltaTime;

            if (m_SpawnTimer <= 0.0f)
            {
                m_CanSpawn = true;
                m_SpawnTimer = SpawnDelay;
            }
        }
    }

    float m_SpawnTimer;
    bool m_CanSpawn;
}
