using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour {

    private GameObject _Enemy;
	// Use this for initialization
	void Awake () {
        _Enemy = GameObject.FindGameObjectWithTag("Enemy");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag("Enemy"))
        {

            _Enemy.GetComponent<EnemyHealth>().TakeDamage(1);

            //Destroy(coll.gameObject);
            //ITakeDamage damagable = Enemy.collider.GetComponent<ITakeDamage>();
            Destroy(gameObject);

        }
    }



}
