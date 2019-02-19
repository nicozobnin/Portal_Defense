using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBase : MonoBehaviour
{
    public enum GunType
    {
        Pistol,
        PlasmaRifle,
        None
    }

    // Use this for initialization
    void Start ()
    {
        m_FireDelay = 0.0f;
        m_GunType = GunType.None;
    }
	
	// Update is called once per frame
	virtual protected void Update ()
    {
        if (m_CanFire == false)
        {
            m_FireDelayTimer -= Time.fixedDeltaTime;

            if (m_FireDelayTimer <= 0.0f)
            {
                m_CanFire = true;
                m_FireDelayTimer = m_FireDelay;
            }
        }
    }

    public float m_FireDelay;
    public GunType m_GunType;

    public bool m_CanFire;
    public float m_FireDelayTimer;
}
