using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Queue<string> sentences;

    public Animator anim;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue words)
    {
        anim.SetBool("IsOpen", true);
        nameText.text = words.name;

        sentences.Clear();

        foreach (string sentence in words.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNext();
    }

    public void DisplayNext()
    {
        if(sentences.Count == 0)
        {
            EndTalk();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.02f);
            yield return null;
        }
    }

    void EndTalk()
    {
        anim.SetBool("IsOpen", false);
    }
}
