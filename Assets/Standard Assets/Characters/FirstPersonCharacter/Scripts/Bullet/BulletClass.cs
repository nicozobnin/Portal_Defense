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
	public virtual void Update ()
    {



	}

    public virtual void applyDamage(GameObject objectToDamage, float damage)
    {
        Enemy enemyToDamage = objectToDamage.GetComponent<Enemy>();
        //call this when dealling damage
            enemyToDamage.TakeDamage(Damage);
    }
   

    Rigidbody bulletRigidBody;

    SphereCollider BulletsphereCollider;

    public string BulletName;

    public float Damage;

    GameObject BulletGameObject;

    float initialVelocity;
}
