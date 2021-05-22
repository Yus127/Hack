using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeRandomMovent",0,2);
    }

    void MakeRandomMovent(){
        Vector2 position = gameObject.transform.position;
        position.x = Random.Range(-100.0f,100.0f);
        gameObject.transform.position = position;
    }

}
