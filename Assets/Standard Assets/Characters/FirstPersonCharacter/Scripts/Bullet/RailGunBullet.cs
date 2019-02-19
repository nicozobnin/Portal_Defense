using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailGunBullet : BulletClass
{

    // Use this for initialization
    void Start()
    {
        Damage = 2.5f;
        BulletName = "Rail";
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
            applyDamage(collision.gameObject, Damage);
        }
    }
}
