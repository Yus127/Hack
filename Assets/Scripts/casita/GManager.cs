using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
public static int count=0;
public GameObject Ended;
public GameObject mommy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count==5){
        print("ya es todo ");
        Ended.gameObject.SetActive(true); 
        Destroy(mommy);
        }
    }
    
}
