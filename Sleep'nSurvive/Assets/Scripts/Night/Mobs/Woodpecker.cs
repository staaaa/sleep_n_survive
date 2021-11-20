using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Woodpecker : MonoBehaviour
{
    public GameObject g;

    public StatsUpdater sh;

    public Animator animator;

    public float speed = 1f;

    public bool j = false;
    bool k = false;
    bool l = false;

    public void BirdMove()
    {
        j = true;
        k = false;
        l = false;

        g.transform.Rotate(0f, 180f, 0f);
    }
    public void BirdMove2()
    {
        if(ItemHandlerer.Wood == 0)
        {
            Vector2 target = new Vector2(-1.12f, 0.35f);
            float step = speed * Time.deltaTime;
            g.transform.position = Vector2.MoveTowards(transform.position, target, step);
        }
        else if (ItemHandlerer.Wood != 0)
        {
            Vector2 target = new Vector2(-1.5f, 0.35f);
            float step = speed * Time.deltaTime;
            g.transform.position = Vector2.MoveTowards(transform.position, target, step);
        }
    }
    public void BirdMove3()
    {
        Vector2 target = new Vector2(-4.65f, 0.35f);
        float step = speed * Time.deltaTime;
        g.transform.position = Vector2.MoveTowards(transform.position, target, step);
    }
    void Update()
    {
        if (j == true)
        {
            BirdMove2();
            if(ItemHandlerer.Wood == 0)
            {
                if (g.transform.position.x == -1.12f)
                {
                    StartCoroutine(wait2());
                    animator.SetBool("attack", true);
                    StartCoroutine(wait());
                    j = false;
                }
            }
            else if (ItemHandlerer.Wood != 0)
            {
                if (g.transform.position.x == -1.5f)
                {
                    StartCoroutine(wait3());
                    animator.SetBool("attack", true);
                    StartCoroutine(wait());
                    ItemHandlerer.Wood--;
                    j = false;
                }
            }
        }
        if(k == true)
        {
            if (l == false)
            {
                g.transform.Rotate(0f, 180f, 0f);
                l = true;
            }
            BirdMove3();
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
        animator.SetBool("attack", false);
        k = true;
    }
    IEnumerator wait2()
    {
        yield return new WaitForSeconds(0.2f);
        sh.hpUpdate(2);
        yield return new WaitForSeconds(0.2f);
        sh.hpUpdate(2);
        yield return new WaitForSeconds(0.2f);
        sh.hpUpdate(2);
        yield return new WaitForSeconds(0.2f);
        sh.hpUpdate(2);
        yield return new WaitForSeconds(0.2f);
        sh.hpUpdate(2);
        yield return new WaitForSeconds(0.2f);
        sh.hpUpdate(1);
        yield return new WaitForSeconds(0.2f);
        sh.hpUpdate(1);
    }
    IEnumerator wait3()
    {
        yield return new WaitForSeconds(1.4f);
    }
}
