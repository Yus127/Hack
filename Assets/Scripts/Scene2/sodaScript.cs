
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sodaScript : MonoBehaviour
{
public Sprite Nuevo;
public Sprite Viejo;

void OnCollisionEnter2D(Collision2D collision){
        
        if (collision.gameObject.tag == "Player" &&  this.gameObject.GetComponent<SpriteRenderer>().sprite==Viejo)
        {
            print("jala");
            this.gameObject.GetComponent<SpriteRenderer>().sprite=Nuevo;
            
            //GameManager.instance.Win();
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
