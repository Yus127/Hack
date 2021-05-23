using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ActivateMiniGame : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
        
        if (collision.gameObject.tag == "Player")
        {
            print("jala");
            SceneManager.LoadScene("AirHockey");
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
