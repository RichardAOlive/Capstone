using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build_building : MonoBehaviour
{
    public GameObject barracks_blueprint;
    public GameObject tower_blueprint;

    public void spawn_barracks_blueprint()
    {
        Instantiate(barracks_blueprint);
    }

        public void spawn_Tower_blueprint()
    {
        Instantiate(tower_blueprint);
    }
}
