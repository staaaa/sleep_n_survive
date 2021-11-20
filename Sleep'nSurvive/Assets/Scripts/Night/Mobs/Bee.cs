using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Bee : MonoBehaviour
{
    public GameObject g;
    public StatsUpdater sh;
    public Animator animator;
    public float speed = 3f;

    bool j = false;

    public void BeeMove()
    {
        j = true;
    }
    public void BeeMove2()
    {
        Vector2 target = new Vector2(-1.962f, 0.13f);
        float step = speed * Time.deltaTime;
        g.transform.position = Vector2.MoveTowards(transform.position, target, step);
    }
    public void BeeMove2_1()
    {
        Vector2 target = new Vector2(-1.29f, -0.55f);
        float step = speed * Time.deltaTime;
        g.transform.position = Vector2.MoveTowards(transform.position, target, step);
    }
    public void BeeMove3()
    {
        g.transform.position = new Vector2(1.85f, 0.15f);
    }
    void Update()
    {
        if(j == true)
        {
            if(ItemHandlerer.flowers == 0)
            {
                BeeMove2();
                if (g.transform.position.x == -1.962f)
                {
                    StartCoroutine(wait());
                }
            }
            else if (ItemHandlerer.flowers > 0)
            {
                BeeMove2_1();
                if(g.transform.position.x == -1.29f)
                {
                    StartCoroutine(wait2());
                }
            }
        }
    }
    IEnumerator wait()
    {
        sh.hpUpdate(10);
        j = false;
        yield return new WaitForSeconds(1.5f);
        BeeMove3();
    }
    IEnumerator wait2()
    {
        j = false;
        yield return new WaitForSeconds(1.5f);
        ItemHandlerer.flowers--;
        BeeMove3();
    }
}
