using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPistol : GunBase
{
    public GameObject Muzzle;

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

            // Raycast for damage
            RaycastHit hit;
            Ray landingRay = new Ray(Muzzle.transform.position, transform.forward);

            if (Physics.Raycast(landingRay, out hit, 1000.0f))
            {
                if (hit.collider.tag == "Enemy")
                {
                    hit.collider.gameObject.GetComponent<Enemy>().TakeDamage(1.0f);
                }
            }
        }
    }
}
