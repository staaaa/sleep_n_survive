using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D1 : MonoBehaviour
{
    public bool entered = false;
    public bool fade = false;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(entered == false)
        {
            STATICDIALOG.d1 = true;
            entered = true;
        }
    }
    private void Update() 
    {
        if(static_next.numer_zdania == 6 && fade == false)
        {
            fade_static.trigger = true;
            fade_static.fade = true;
            fade = true;
        }
    }
}
