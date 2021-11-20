using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSentence : MonoBehaviour
{

    public Dialogue_Manager d;

    void Update()
    {
        if(static_next.can_next == true)
        {
            if (Input.GetKeyUp(KeyCode.Z) && d.kon == false)
            {
                d.zd = false;
                d.DisplayNextSentence();
            }
            else if (Input.GetKeyUp(KeyCode.X))
            {
                d.zd = true;
                d.kon = false;
                d.FullSentence();
            }
        }
    }

}
