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

    private int counterQuestions = 0;
    //falta asignar los puntos y lo de ganar y perder
    private int counterPoints;

    public void ChoiceOption1(){
        counterQuestions  += 1;
        if (counterQuestions  == 1){
            TextBox.GetComponent<Text>().text="A";    
        }
        else if (counterQuestions  == 2){
            TextBox.GetComponent<Text>().text="A2"; 
        }
        else if (counterQuestions  == 3){
            TextBox.GetComponent<Text>().text="A3"; 
        }

    }

    public void ChoiceOption2(){
        counterQuestions  += 1;
        if (counterQuestions  == 1){
            TextBox.GetComponent<Text>().text="B";    
        }
        else if (counterQuestions  == 2){
            TextBox.GetComponent<Text>().text="B2"; 
        }
        else if (counterQuestions  == 3){
            TextBox.GetComponent<Text>().text="B3"; 
        }

    }

    public void Prueba(){
         counterQuestions  += 1;
            if (counterQuestions  == 1){
            TextBox.GetComponent<Text>().text="Caca";    
        }
        else if (counterQuestions  == 2){
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
        if (counterQuestions  == 1){
            Choice01.SetActive(false);
            Choice02.SetActive(false);
            Choice03.SetActive(true);
            Choice04.SetActive(true);
        }
        else if (counterQuestions  == 2){
            Choice03.SetActive(false);
            Choice04.SetActive(false);
            Choice05.SetActive(true);
            Choice06.SetActive(true);
        }
        else if (counterQuestions  == 3){
            Choice05.SetActive(false);
            Choice06.SetActive(false);
        }
    }
        
    }
