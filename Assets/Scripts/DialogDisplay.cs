using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogDisplay : MonoBehaviour
{
    public Conversation convo;
    
    public GameObject speaker1;
    public GameObject speaker2;

    private SpeakerUI speakerUI1;
    private SpeakerUI speakerUI2;
    
    

    private int activateLineIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        speakerUI1 = speaker1.GetComponent<SpeakerUI>();
        speakerUI2 = speaker2.GetComponent<SpeakerUI>();

        speakerUI1.Speaker = convo.speaker1;
        speakerUI2.Speaker = convo.speaker2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            AdvanceConvo();
        }
    }

    void AdvanceConvo(){
        if(activateLineIndex < convo.lines.Length){
            DisplayLine();
            activateLineIndex +=1;
        }
        else 
        {
           speakerUI1.Hide();
           speakerUI2.Hide();
           activateLineIndex = 0;
        }
    }

    void DisplayLine(){
        Line line = convo.lines[activateLineIndex];
        NPC npc = line.character;

        if(speakerUI1.SpeakerIs(npc)){
        SetDialog(speakerUI1, speakerUI2,line.text);
        speakerUI2.Hide();
        }
        else{
        SetDialog(speakerUI2, speakerUI1,line.text);
        speakerUI1.Hide();
        }
    }

    void SetDialog(SpeakerUI activeSpeakerUI, SpeakerUI inactiveSpeakerUI, string text) {
        activeSpeakerUI.Dialog = text;
        activeSpeakerUI.Show();
    }
}
