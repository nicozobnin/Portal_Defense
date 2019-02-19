using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletClass : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {


    }


	
    // Update is called once per frame
	void Update ()
    {



	}

    public virtual void applyDamage(GameObject objectToDamage)
    {
        Enemy enemyToDamage = objectToDamage.GetComponent(typeof(Enemy)) as Enemy;
        //call this when dealling damage
        if(objectToDamage == enemyToDamage)
        {
            enemyToDamage.TakeDame(Damage);
        }

    }
   

    Rigidbody bulletRigidBody;

    SphereCollider BulletsphereCollider;

    public string BulletName;

    public float Damage;

    GameObject BulletGameObject;

}
