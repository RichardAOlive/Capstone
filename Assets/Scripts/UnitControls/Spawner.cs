using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class Spawner : MonoBehaviour
{
    public GameObject Prefab;
    
    

    public void SpawnUnit()
    {
        Vector3 spawnpoint = transform.position;
        Vector3 spawnoffset = spawnpoint + new Vector3(5f, 0, 0);
        
        Instantiate(Prefab, spawnoffset, transform.rotation);
    }

    // Update is called once per frame
    public void OnMouseDown()
    {
    

        SpawnUnit();
    }
}
