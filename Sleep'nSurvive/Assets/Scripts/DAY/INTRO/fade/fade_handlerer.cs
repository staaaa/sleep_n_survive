using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade_handlerer : MonoBehaviour
{
    bool x = false;
    float y = 1;

    public SpriteRenderer GameObject;

    void Update()
    {
        if(fade_static.koniec == true && x == false)
        {
            Zmiana();
            x = true;
        }
    }

    void Zmiana()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        for(int i = 0; i<100; i++)
        {
            y-=0.01f;
            GameObject.color = new Color(0,0,0,y);
            yield return new WaitForSeconds(0.001f);
        }
    }
}
