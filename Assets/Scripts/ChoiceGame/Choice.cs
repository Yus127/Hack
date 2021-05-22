using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choice : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;

    public GameObject Choice03;
    public GameObject Choice04;

    public GameObject Choice05;
    public GameObject Choice06;

    public Button btnUp;
    public Button btnDown;

    private int counterQuestions = 0;
    //falta asignar los puntos y lo de ganar y perder
    public int counterPoints= 0;


    void Start() {
        
        
    }
    public void ChoiceOption1(){
        counterQuestions  += 1;
        if (counterQuestions  == 1){
            TextBox.GetComponent<Text>().text="Págame o llamo a la policía."; 
               counterPoints-= 1;
        }
        else if (counterQuestions  == 2){
            TextBox.GetComponent<Text>().text="No te preocupes, fue un accidente."; 
            counterPoints+= 1;
        }
        else if (counterQuestions  == 3){
            TextBox.GetComponent<Text>().text="Ya pasó, ten más cuidado."; 
            counterPoints+= 1;
        }

    }

    public void ChoiceOption2(){
        counterQuestions  += 1;
        if (counterQuestions  == 1){
            TextBox.GetComponent<Text>().text="Ahora tienes que limpiar y pagármelos.";
            counterPoints+= 1;    
        }
        else if (counterQuestions  == 2){
            TextBox.GetComponent<Text>().text="¡Salte de mi tienda!"; 
            counterPoints-= 1; 
        }
        else if (counterQuestions  == 3){
            TextBox.GetComponent<Text>().text="Te lo advertí, voy a llamar a la policía."; 
            counterPoints-= 1; 
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
            // Choice05.SetActive(false);
            // Choice06.SetActive(false);
            btnUp.gameObject.SetActive(false);
            btnDown.gameObject.SetActive(false);
            if(counterPoints >= 0)
            {
                StartCoroutine(Winner());
            }else StartCoroutine(Loser());
        }
        
    }

    IEnumerator Winner()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("fiesta");
    }

    IEnumerator Loser()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("ChoiceGame");
    }
        
    }
