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

    public virtual void applyDamage()
    {
        //call this when dealling damage


    }


    Rigidbody bulletRigidBody;
    SphereCollider BulletsphereCollider;

    public string BulletName;
    public float Damage;
    GameObject BulletGameObject;

}
