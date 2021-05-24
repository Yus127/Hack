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
          //  DontDestroyOnLoad(this.gameObject);

        //count=0;
    }
    void Awake()
    {
        GameObject[] objs =GameObject.FindGameObjectsWithTag("contador3");
        if(objs.Length > 1){
        Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
    print(count);
    if(count==11){
    
        print("ya es todo ");
        
        SceneManager.LoadScene("Reflexion");
        count=count+1;
        //Ended.gameObject.SetActive(true); 
        //Destroy(mommy);
        }
        
    }
}
