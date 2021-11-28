using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerd1 : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<Dialogue_Manager>().StartDialogue(dialogue);
    }

    void Update()
    {
        if (STATICDIALOG.d1 == true)
        {
            TriggerDialogue();
            STATICDIALOG.d1 = false;
        }
    }
}
