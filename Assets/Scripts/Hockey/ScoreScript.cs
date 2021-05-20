using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
     public GameObject GameOverText;
     public Text Won;
     public Text Lost;

  public enum Score
    {
        AiScore, PlayerScore
    }

    public Text AiScoreTxt, PlayerScoreTxt;
    private int aiScore, playerScore;

    public void Increment(Score whichScore)
    {
        if (whichScore == Score.AiScore){
            AiScoreTxt.text = (++aiScore).ToString();
            if(aiScore>1){
            print("perdiste");
            GameOverText.gameObject.SetActive(true); 
            Lost.gameObject.SetActive(true);
            }
            }
        else{
            PlayerScoreTxt.text = (++playerScore).ToString();
            if(playerScore>1){
            print("ganaste");
            GameOverText.gameObject.SetActive(true); 
            Won.gameObject.SetActive(true);
            }
            }
            
    }
}
