using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade_handlerer : MonoBehaviour
{
    float y = 1;
    int j = 0;

    public SpriteRenderer GameObject;

    private void Update() 
    {
        if(fade_static.trigger == true)
        {
            Zmiana(fade_static.fade);
            fade_static.trigger = false;
        }
    }
    void Zmiana(bool i)
    {
        if(i == true)
        {
            StartCoroutine(wait1());
        }
        else if(i == false)
        {
            StartCoroutine(wait2());
        }
    }

    IEnumerator wait1()
    {
        for(j = 0; j<100; j++)
        {
            y-=0.01f;
            GameObject.color = new Color(0,0,0,y);
            yield return new WaitForSeconds(0.001f);
        }
    }
    IEnumerator wait2()
    {
        for(j = 0; j<100; j++)
        {
            y+=0.01f;
            GameObject.color = new Color(0,0,0,y);
            yield return new WaitForSeconds(0.001f);
        }
    }
}
