using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int Seconds;
    public GameObject TheGameObjectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",0,Seconds);
    }


    void Spawn(){
        Instantiate(TheGameObjectToSpawn, gameObject.transform.position, Quaternion.identity);
    }
}
