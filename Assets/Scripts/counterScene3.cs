using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class counterScene3 : MonoBehaviour
{
public static int count=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(count==2){
        print("ya es todo ");
        SceneManager.LoadScene("final");
        //Ended.gameObject.SetActive(true); 
        //Destroy(mommy);
        }
        
    }
}
