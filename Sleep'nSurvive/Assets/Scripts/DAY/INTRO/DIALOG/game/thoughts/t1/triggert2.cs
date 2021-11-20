using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggert2 : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<Dialogue_Manager>().StartDialogue(dialogue);
    }

    void Update()
    {
        if (STATICDIALOG.t2 == true)
        {
            TriggerDialogue();
            STATICDIALOG.t2 = false;
        }
    }
}
