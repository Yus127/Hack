using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerScene3 : MonoBehaviour
{
 public static int counter= 0;
   [SerializeField] GameObject win;
   [SerializeField] GameObject lost;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        win.SetActive(false);
        lost.SetActive(false);
        
       if(counter == 14 && CountDownTimer.currentTime >= 0){
           print("Win");
        win.SetActive(true);
       } else if(CountDownTimer.currentTime == 0){
           print("Lost");
           lost.SetActive(true);
       }
    }

}
