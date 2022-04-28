using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool isBuilding = false;
    public float enemyHealth = 100;
    public float damage = 20;
    public bool alive = true;
    public void TakeDamage (float amount)
    {
        if(!alive)
        {
            return;
        }

        if (enemyHealth <= 0)
        {
            enemyHealth = 0;
            //remove object on death
            alive = false;
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
        enemyHealth -= amount;
    }

    void OnTriggerEnter (Collider other)
    {
        if(isBuilding==false)
        {
            if(other.gameObject.tag == "Clickable")
            {
                other.gameObject.GetComponent<Unit>().TakeDamage(damage);
            }
        }
    }
}


