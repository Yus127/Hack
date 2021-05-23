using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
  
   public void OnMouseDown() {
        gameObject.active = false;
        Destroy(gameObject);
        ControllerScene3.counter += 1;
    
//   renderer.enabled = false;
    }



    
}
