using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    public Text characterNameText;
    public Image characterPortrait;
    public Image backgroundImage;
    
    private Queue<string> dialogues;
    
    void Start()
    {
        dialogues = new Queue<string>();
    }
    
    public void StartDialogue(Dialogue dialogue)
    {
        dialogues.Clear();
        
        foreach (string sentence in dialogue.sentences)
        {
            dialogues.Enqueue(sentence);
        }
        
        DisplayNextSentence();
    }
    
    public void DisplayNextSentence()
    {
        if (dialogues.Count == 0)
        {
            EndDialogue();
            return;
        }
        
        string sentence = dialogues.Dequeue();
        dialogueText.text = sentence;
    }
    
    void EndDialogue()
    {
        Debug.Log("End of dialogue");
    }
}
