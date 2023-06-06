using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text DialogueText;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        
    }

    public void beginDialogue(newDialogue dialogue){
        sentences.Clear();

        foreach (string sentence in dialogue.dialogues){
            sentences.Enqueue(sentence);
        }

        showDialogue();
    }

    public void showDialogue(){
        string sentence = sentences.Dequeue();
        DialogueText.text = sentence;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
