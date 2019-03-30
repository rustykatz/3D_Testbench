using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAtRandomLocation : MonoBehaviour
{
    // Empty Objects
    public GameObject spawn_1;
    public GameObject spawn_2;
    public GameObject spawn_3;

    public GameObject toSpawn; // Object you want to spawn
    //public GameObject toSpawnLoc;

    public int obj_index; // used to store randomly generated number 

    public List<GameObject> loc = new List<GameObject>();

    //Array version that uses tags. Obj pos in array depends on hierarchy 
    // GameObject[] objs = GameObject.FindGameObjectsWithTag("Flag");
    void Start()
    {
        // Version 1: Hardcode ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //Init array
        /*
        obj_index = Random.Range(0, 3);
        Debug.Log(obj_index);

        if(obj_index == 0)
        {
            toSpawnLoc = spawn_1;
        }
        if(obj_index == 1)
        {
            toSpawnLoc = spawn_2;
        }
        if(obj_index == 2)
        {
            toSpawnLoc = spawn_3;
        }

        GameObject go = Instantiate(toSpawn, toSpawnLoc.transform.position, Quaternion.identity);
        */


        // Version 2: List ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        loc.Add(spawn_1);
        loc.Add(spawn_2);
        loc.Add(spawn_3);

        obj_index = Random.Range(0, 3);

        Instantiate(toSpawn, loc[obj_index].transform.position, Quaternion.identity);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
