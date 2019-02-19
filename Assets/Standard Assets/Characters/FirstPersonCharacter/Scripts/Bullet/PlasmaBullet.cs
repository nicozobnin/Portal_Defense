using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaBullet : BulletClass
{


    float bulletIntegrity;
    // Use this for initialization
    void Start()
    {
        Damage = 2.5f;
        bulletIntegrity = 10;
        BulletName = "Plasma";
    }


    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }


    public override void applyDamage(GameObject objectToDamage, float damage)
    {
        base.applyDamage(objectToDamage, damage);
    }
    private void OnCollisionEnter(Collision collision)
    {

        Enemy enemyToDamage = collision.gameObject.GetComponent<Enemy>();
        //call this when dealling damage
        if (enemyToDamage)
        {
            bulletIntegrity -= 3;
            if(bulletIntegrity>0.1f)
            {
                applyDamage(collision.gameObject, Damage);
            }
            else if( bulletIntegrity  <  0)
            {
                Destroy(this);
            }
        }

    }
}
