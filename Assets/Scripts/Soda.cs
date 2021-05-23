using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Soda : MonoBehaviour
{
  public Sprite Nuevo;
public Sprite Viejo;
public GameObject door;

void OnCollisionEnter2D(Collision2D collision){
        
        if (collision.gameObject.tag == "Player" &&  this.gameObject.GetComponent<SpriteRenderer>().sprite==Viejo)
        {
            print("jala");
            this.gameObject.GetComponent<SpriteRenderer>().sprite=Nuevo;
            GManager.count = GManager.count + 1;
             StartCoroutine(TirarRefresco());
            //GameManager.instance.Win();
        }

        
    }

     void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag =="Player" && this.gameObject == door){
        
       StartCoroutine(TirarRefresco());
        
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
      IEnumerator TirarRefresco()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("DialogoTienda");
    }
}
