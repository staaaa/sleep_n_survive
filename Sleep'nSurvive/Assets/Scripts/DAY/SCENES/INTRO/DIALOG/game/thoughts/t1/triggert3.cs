using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggert3 : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<Dialogue_Manager>().StartDialogue(dialogue);
    }

    void Update()
    {
        if (STATICDIALOG.t3 == true)
        {
            TriggerDialogue();
            STATICDIALOG.t3 = false;
        }
    }
}
