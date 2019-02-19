using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPistol : GunBase
{

    // Use this for initialization
    void Start()
    {
        m_GunType = GunType.Pistol;
        m_FireDelay = 0.1f;
        m_FireDelayTimer = m_FireDelay;

        m_CanFire = true;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    public void Fire()
    {
        if (m_CanFire == true)
        {
            m_CanFire = false;
        }
    }
}
