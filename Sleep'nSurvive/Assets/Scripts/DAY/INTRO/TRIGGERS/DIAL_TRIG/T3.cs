using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T3 : MonoBehaviour
{
    public bool entered = false;
    private void OnTriggerEnter2D(Collider2D other)
    {   
        if(entered == false)
        {
            STATICDIALOG.t3 = true;
            entered = true;
        }
    }
}
