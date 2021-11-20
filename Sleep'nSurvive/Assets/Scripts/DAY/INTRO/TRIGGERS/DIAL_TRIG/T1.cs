using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1 : MonoBehaviour
{
    public bool entered = false;
    private void OnTriggerEnter2D(Collider2D other)
    {   
        if(entered == false)
        {
            STATICDIALOG.t1 = true;
            entered = true;
        }
    }
}
