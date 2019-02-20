using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPistol : GunBase
{
    public GameObject Muzzle;
    [SerializeField]
    float bulletRadius = 0.125f;
    // Use this for initialization
    void Start()
    {
        m_GunType = GunType.Pistol;
        m_FireDelayTimer = m_FireDelay;

        m_CanFire = true;
    }
    CharacterController charCtrl;
    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    public override void Fire()
    {
        if (m_CanFire == true)
        {
            m_CanFire = false;

            // Raycast for damage
            RaycastHit hit;
            Ray landingRay = new Ray(Muzzle.transform.position,  Camera.main.transform.forward * 10);

            float distanceToObstacle = 0;

            // Cast a sphere wrapping character controller 10 meters forward
            // to see if it is about to hit anything.
            if (Physics.SphereCast(Camera.main.transform.position, bulletRadius, Camera.main.transform.forward, out hit, 100))
            {
                distanceToObstacle = hit.distance;
                Enemy enemyHit = hit.collider.gameObject.GetComponent<Enemy>();
                if (enemyHit)
                {
                    enemyHit.TakeDamage(100.0f);
                }
            }



            Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward, Color.green,10.0f);
            Debug.DrawLine(Camera.main.transform.forward,  Camera.main.transform.forward * 10, Color.red, 3.0f);
            /*if (Physics.Raycast(landingRay, out hit, 1000.0f))
            {
                Enemy enemyHit = hit.collider.gameObject.GetComponent<Enemy>();
                if (enemyHit)
                {
                    enemyHit.TakeDamage(100.0f);
                }
            }
            */
        }
    }
}
