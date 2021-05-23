using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitQuitEnd : MonoBehaviour
{
     public KeyCode key = KeyCode.Escape;

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            Application.Quit();
        }
    }
/*
    public void EXITtoMenu()
    {
        FindObjectOfType<GameManager>().Load(1);
    }
    */
    public void EXIT()
    {
        Application.Quit();
       
    }
}
