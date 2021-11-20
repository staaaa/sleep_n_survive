using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggert1 : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<Dialogue_Manager>().StartDialogue(dialogue);
    }

    void Update()
    {
        if (STATICDIALOG.t1 == true)
        {
            TriggerDialogue();
            STATICDIALOG.t1 = false;
        }
    }
}
