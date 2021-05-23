using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
 public bool toggle = true;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            ToggleSound();
        }

    }

    // Update is called once per frame
    void Awake()
    {
        GameObject[] objs =GameObject.FindGameObjectsWithTag("music");
        if(objs.Length > 1){
        Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
     public void ToggleSound()
    {
        toggle = !toggle;

        if (toggle)
            AudioListener.volume = 1f;

        else
            AudioListener.volume = 0f;
    }

}
