using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerd2 : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<Dialogue_Manager>().StartDialogue(dialogue);
    }

    void Update()
    {
        if (STATICDIALOG.d2 == true)
        {
            TriggerDialogue();
            STATICDIALOG.d2 = false;
        }
    }
}
