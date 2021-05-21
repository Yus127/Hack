using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;

    public GameObject Choice03;
    public GameObject Choice04;

    public GameObject Choice05;
    public GameObject Choice06;

    private int counterPoints= 0;

    public void ChoiceOption1(){
        counterPoints += 1;
        if (counterPoints == 1){
            TextBox.GetComponent<Text>().text="A";    
        }
        else if (counterPoints == 2){
            TextBox.GetComponent<Text>().text="A2"; 
        }
        else if (counterPoints == 3){
            TextBox.GetComponent<Text>().text="A3"; 
        }

    }

    public void ChoiceOption2(){
        counterPoints += 1;
        if (counterPoints == 1){
            TextBox.GetComponent<Text>().text="B";    
        }
        else if (counterPoints == 2){
            TextBox.GetComponent<Text>().text="B2"; 
        }
        else if (counterPoints == 3){
            TextBox.GetComponent<Text>().text="B3"; 
        }

    }

    public void Prueba(){
         counterPoints += 1;
            if (counterPoints == 1){
            TextBox.GetComponent<Text>().text="Caca";    
        }
        else if (counterPoints == 2){
            TextBox.GetComponent<Text>().text="Caca1";    
        }
    }


    // Update is called once per frame
    void Update()
    {
        
        Choice03.SetActive(false);
        Choice04.SetActive(false);
        Choice05.SetActive(false);
        Choice06.SetActive(false);
        if (counterPoints == 1){
            Choice01.SetActive(false);
            Choice02.SetActive(false);
            Choice03.SetActive(true);
            Choice04.SetActive(true);
        }
        else if (counterPoints == 2){
            Choice03.SetActive(false);
            Choice04.SetActive(false);
            Choice05.SetActive(true);
            Choice06.SetActive(true);
        }
        else if (counterPoints == 3){
            Choice05.SetActive(false);
            Choice06.SetActive(false);
        }
    }
        
    }
