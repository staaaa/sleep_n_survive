using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue_Manager : MonoBehaviour
{
    private Queue<string> sentences;

    public float delay = 0.001f;

    public Text dialogueText;

    public string zdanie;

    public bool zd;

    public bool kon;

    public RectTransform bar;


    void Start()
    {
        kon = true;
        zd = false;
    }

    public void StartDialogue(Dialogue dialogue)
    {
        bar.anchoredPosition = new Vector2(-11f, -225f);
        static_walk.can_walk = false;
        static_next.numer_zdania = 0;

        sentences = new Queue<string>();
        kon = true;
        zd = false;
        sentences.Clear();

        foreach(string sent in dialogue.sentences)
        {
            sentences.Enqueue(sent);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        static_next.numer_zdania++;
        kon = true;
        if (sentences.Count != 0)
        {
            StartCoroutine(wait());
        }
        else if (sentences.Count == 0)
        {
            EndDialogue();
        }
    }
    IEnumerator wait()
    {
        string sent = sentences.Dequeue();
        zdanie = sent;
        string sent2;
        for (int i = 0; i <= sent.Length; i++)
        {
            if (zd == false)
            {
                sent2 = sent.Substring(0, i);
                dialogueText.text = sent2;
                yield return new WaitForSeconds(delay);
            }
            else yield break; 
        }
        kon = false;
    }

    void EndDialogue()
    {
        bar.anchoredPosition = new Vector2(-11f, -1000f);

        dialogueText.text = "";
        zdanie = "";
        zd = false;
        static_walk.can_walk = true;
    }

    public void FullSentence()
    {
        dialogueText.text = zdanie;   
    }
}
