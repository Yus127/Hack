using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void BtnNew()
    {
        counterScene3.count = counterScene3.count+1;
        SceneManager.LoadScene("fiesta");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
