using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance =null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake(){
    if (instance ==null){
    instance =this;
    }else if (instance != null){
    Destroy(gameObject);
    }
    }
    public void Win(){
    SceneManager.LoadScene("AirHockey");
    print("wuuu");
    }
}
