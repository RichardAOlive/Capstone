using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public bool isBuilding = false;
    public float curHealth = 100f;
    public bool alive = true;
    public float damage = 25;
    // Start is called before the first frame update
    void Start()
    {
        if(isBuilding == false)
        {
            UnitSelections.Instance.unitList.Add(this.gameObject);
        }
    }

    void onDestroy()
    {
        if(isBuilding == false)
        {
            UnitSelections.Instance.unitList.Remove(this.gameObject);
        }
    }

    public void TakeDamage (float amount)
    {
        if(!alive)
        {
            return;
        }

        if (curHealth <= 0)
        {
            curHealth = 0;
            //remove object on death
            alive = false;
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
        curHealth -= amount;
    }

    void OnTriggerEnter (Collider other)
    {
        if(isBuilding == false)
        {
            if(other.gameObject.tag == "Enemy")
            {
                other.gameObject.GetComponent<Enemy>().TakeDamage(damage);
            }
        }
    }
}
