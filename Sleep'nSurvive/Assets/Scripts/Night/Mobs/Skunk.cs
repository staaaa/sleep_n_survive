using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Skunk : MonoBehaviour
{
    public GameObject g;
    public GameObject skunks;
    public StatsUpdater sh;
    public Animator animator;
    public float speed = 2f;

    public bool j = false;
    public bool k = false;

    public void SkunkMove()
    {
        j = true;
    }
    public void SkunkMove2()
    {
        Vector2 target = new Vector2(-1.2f, -0.12f);
        float step = speed * Time.deltaTime;
        g.transform.position = Vector2.MoveTowards(transform.position, target, step);
    }
    public void SkunkMove3()
    {
        Vector2 target2 = new Vector2(3.5f, -0.12f);
        float step2 = speed * Time.deltaTime;
        g.transform.position = Vector2.MoveTowards(transform.position, target2, step2);
    }
    void Update()
    {
        if (j == true)
        {
            SkunkMove2();
            if (g.transform.position.x == -1.2f)
            {
                skunks.transform.Rotate(0f,180f,0f);
                if (ItemHandlerer.TomatoJuice == 0 && Stats.smrod == false)
                {
                    Stats.smrod = true;
                }
                else if (ItemHandlerer.TomatoJuice > 0)
                {
                    ItemHandlerer.TomatoJuice--;
                }
                
                animator.SetBool("spraying", true);
                StartCoroutine(wait());
                j = false;   
            }
        }
        if (k == true)
        {
            SkunkMove3();
            if(g.transform.position.x == 3.5f)
            {
                k = false;
                skunks.transform.Rotate(0f, 180f, 0f);
            }
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
        animator.SetBool("spraying", false);
        k = true;
    }
}
