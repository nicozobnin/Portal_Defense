using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnDelay;
    public Enemy SpawningEnemy;
    public Vector3 SpawnOffset;

	// Use this for initialization
	void Start ()
    {
        m_SpawnTimer = SpawnDelay;
    }
	
	// Update is called once per frame
	void Update ()
    {
        m_SpawnTimer -= Time.fixedDeltaTime;

        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        if (m_SpawnTimer <= 0.0f)
        {
            m_SpawnTimer = SpawnDelay;

            Vector3 pos = transform.position;
            pos.y += 2.0f;
            Instantiate(SpawningEnemy, pos, transform.rotation);
        }
    }
    
    float m_SpawnTimer;
}
