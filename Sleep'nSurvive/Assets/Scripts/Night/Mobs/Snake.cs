using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Snake : MonoBehaviour
{
    public GameObject g;
    public StatsUpdater sh;
    public Animator animator;
    public float speed = 5f;

    public GameObject flute;

    bool j = false;
    bool k = false;
    bool dmg = false;
    bool rotate = false;
    bool rotate2 = false;

    public void SnakeMove()
    {
        j = true;
        k = false;
        dmg = false;
        rotate = false;
        rotate2 = false;
    }
    public void SnakeMove2()
    {
        Vector2 target = new Vector2(-0.2f, -0.12f);
        float step = speed * Time.deltaTime;
        g.transform.position = Vector2.MoveTowards(transform.position, target, step);
    }
    public void SnakeMove3()
    { 
        Vector2 target = new Vector2(4.5f, -0.12f);
        float step = speed * Time.deltaTime;
        g.transform.position = Vector2.MoveTowards(transform.position, target, step);
    }
    void Update()
    {
        if(j == true)
        {
            SnakeMove2();
            if(g.transform.position.x == -0.2f)
            {
                if (ItemHandlerer.Flute > 0)
                {
                    flute.transform.position = new Vector2(10f, 10f);
                    AnimationIdi.playingFlute = true;
                    StartCoroutine(wait2());
                }
                else if(ItemHandlerer.Flute == 0 && dmg == false)
                {
                    if (Stats.smrod == true)
                    {
                        sh.hpUpdate(8);
                        animator.SetBool("bite", true);
                        g.transform.position = new Vector2(g.transform.position.x, 0.32f);
                        StartCoroutine(wait());
                    }
                    else if (Stats.smrod == false)
                    {  
                        animator.SetBool("bite", true);
                        sh.hpUpdate(5);
                        g.transform.position = new Vector2(g.transform.position.x, 0.32f);
                        StartCoroutine(wait());
                    }
                    if(ItemHandlerer.antidote == 0 && Stats.poison == false)
                    {
                        Stats.poison = true;
                        sh.poison();
                    }
                    else if(ItemHandlerer.antidote > 0)
                    {
                        ItemHandlerer.antidote--;
                    }
                    dmg = true;
                }
                j = false;
            }
        }
        if(k == true)
        {
            if (ItemHandlerer.Flute > 0)
            {
                flute.transform.position = new Vector2(0.044f, -1.05f);
            }
            if (rotate == false)
            {
                ItemHandlerer.Flute--;
                g.transform.Rotate(0f, 180f, 0f);
                rotate = true;
            }
            SnakeMove3();
            if (g.transform.position.x == 4.5f && rotate2 == false)
            {
                g.transform.Rotate(0f, 180f, 0f);
                rotate2 = true;
            }
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
        g.transform.position = new Vector2(4.5f, -0.12f);
        animator.SetBool("bite", false);
    }
    IEnumerator wait2()
    {
        yield return new WaitForSeconds(2f); 
        j = false;
        k = true;
    }
}
