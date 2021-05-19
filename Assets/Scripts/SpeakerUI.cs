using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeakerUI : MonoBehaviour
{
    public Image portrait;
    public Text name;
    public Text dialog;

    private NPC speaker;

    public NPC Speaker {
        get{ return speaker; }
        set{
            speaker = value;
            portrait.sprite = speaker.portrait;
            name.text = speaker.name;
        }
    }

    public string Dialog{
        set { dialog.text = value;}
    }

    public bool HasSpeaker(){
        return speaker != null;
    }

    public bool SpeakerIs(NPC character){
        return speaker == character;
    }
    public void Show(){
        gameObject.SetActive(true);
    }

    public void Hide(){
    gameObject.SetActive(false);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
