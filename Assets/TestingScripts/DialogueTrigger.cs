using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue words;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(words);
    }
}
