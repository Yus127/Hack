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



    public int ChoiceMade;

    public int counterPoints = 1;
    public int counterQuestions = 0;

    public void ChoiceOption1 (){
        TextBox.GetComponent<Text>().text="¡Oye, tiraste todos mis refrescos, fíjate!";
        ChoiceMade = 1;
        counterPoints += -1;
        
    }

    public void ChoiceOption2 (){
        TextBox.GetComponent<Text>().text="Bla hiiii";
        ChoiceMade = 2;
        counterPoints += 1;

    }

     void Start()
     {
         
     }


    // Update is called once per frame
    void Update()
    {
        Choice03.SetActive(false);
        Choice04.SetActive(false);
        Choice05.SetActive(false);
        Choice06.SetActive(false);
        if (counterPoints >= 0){
            Choice01.SetActive(false);
            Choice02.SetActive(false);
            Choice03.SetActive(true);
     }
        }
        
    }
