using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//To create a new character directly from the menu
[CreateAssetMenu(fileName = "NPC", menuName = "NPC", order = 0)]
public class NPC : ScriptableObject {
    
    public Sprite portrait;
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
