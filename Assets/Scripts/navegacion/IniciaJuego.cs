
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciaJuego : MonoBehaviour
{
    // Start is called before the first frame update
    public void BtnNew()
    {
        SceneManager.LoadScene("casita");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

