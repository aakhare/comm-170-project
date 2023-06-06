using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialoguePrompter : MonoBehaviour
{
    public newDialogue dialogue;
    // Start is called before the first frame update
    public void promptDialouge(){
        FindObjectOfType<dialogueManager>().beginDialogue(dialogue);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
