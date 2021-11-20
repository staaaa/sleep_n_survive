using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dUpdater : MonoBehaviour
{
    public GameObject pozycja_gracza;

    bool d1 = true;

    void Start()
    {
        if(d1 == true)
        {
            STATICDIALOG.d1 = true;
        }
        d1 = false;
    }
}
