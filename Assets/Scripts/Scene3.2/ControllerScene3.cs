using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControllerScene3 : MonoBehaviour
{
 public static int counter= 0;
   [SerializeField] GameObject win;
   [SerializeField] GameObject lost;

   private Scene scene;
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        win.SetActive(false);
        lost.SetActive(false);
        
       if(counter == 14 && CountDownTimer.currentTime >= 0){
           print("Win");
           StartCoroutine(Winner());
        win.SetActive(true);
       } else if(CountDownTimer.currentTime == 0){
           lost.SetActive(true);
            StartCoroutine (Loser());
       }
    }

    IEnumerator Winner()
    {
    
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("fiesta");
    }
    IEnumerator Loser()
    {
    counterScene3.count=counterScene3.count+1;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(scene.name);
    }

}
