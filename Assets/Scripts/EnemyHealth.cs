using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour {


    private int health = 3;
    // Display Enemy Test health in UI
    public Text health_txt; 



	// Use this for initialization
    void Start () {
       
		
	}
	
	// Update is called once per frame
	void Update () {
        health_txt.text = "Enemy Health: " + health.ToString(); 
	}

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    //void OnTriggerEnter(Collider coll)
    //{
    //    if (coll.gameObject.CompareTag("Projectile"))
    //    {
    //        Destroy(coll.gameObject);
    //        Destroy(gameObject);

    //    }
    //}
}
