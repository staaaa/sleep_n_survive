using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D2 : MonoBehaviour
{
    public Transform cameraa;
    public Transform squir;
    public Transform victor; 

    public float speed = 0.5f;

    public bool entered = false;
    public bool squirEntered = false;
    public bool do_konca = false;

    private void OnTriggerEnter2D(Collider2D other)
    {   
        if(entered == false)
        {
            STATICDIALOG.d2 = true;
            squirEntered = true;
            entered = true;
        }
    }

    void squirEnter()
    {
        //1.61f, 26.61f, -10f
        Vector2 target = new Vector2(1.61f, 26.61f);
        float step = 5f * Time.deltaTime;
        squir.transform.position = Vector2.MoveTowards(squir.transform.position, target, step);
        cameraa.transform.position = new Vector3(squir.transform.position.x, squir.transform.position.y,-10);

        // squir.transform.position = new Vector2(0.4f, 28.1f);

        static_next.can_next = false;
    }

    void squirOut()
    {
        Vector2 target = new Vector2(0.4f, 80.1f);
        float step = 7f * Time.deltaTime;
        squir.transform.position = Vector2.MoveTowards(squir.transform.position, target, step);

        cameraa.transform.position = new Vector3(victor.transform.position.x, victor.transform.position.y,-10);
    }

    void Update()
    {
        if(squirEntered == true)
        {
            squirEnter();
            if(squir.transform.position.y == 26.61f && squir.transform.position.x == 1.61f)
            {
                squirEntered = false;
                static_next.can_next = true;
            }
        }
        if(static_next.numer_zdania == 11 || do_konca == true)
        {
            squirOut();
            do_konca = true;
        }
    }
}
