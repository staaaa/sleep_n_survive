using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class StatsUpdater : MonoBehaviour
{

    public Text zycie;
    public Text woda;
    public Text jedzenie;
    public Text hajs;

    private int health;
    private int food = Stats.food;
    private int water = Stats.water;

    public void hpUpdate(int a)
    {
        int b = a;
        StartCoroutine(hp(b));
    }
    IEnumerator hp(int a)
    {
        for (int i = 0; i < a; i++)
        {
            Stats.hp--;
            zycie.text = "HP : " + Convert.ToString(Stats.hp);
            yield return new WaitForSeconds(0.05f);
        }
    }
    public void waterUpdate(int a)
    {
        int b = a;
        StartCoroutine(wat(b));
    }
    IEnumerator wat(int a)
    {
        for (int i = 0; i < a; i++)
        {
            Stats.water--;
            woda.text = "WATER:" + Convert.ToString(Stats.water);
            yield return new WaitForSeconds(0.05f);
        }
    }
    public void foodUpdate(int a)
    {
        int b = a;
        StartCoroutine(fud(b));
    }
    IEnumerator fud(int a)
    {
        for (int i = 0; i < a; i++)
        {
            Stats.food--;
            jedzenie.text = "FOOD:" + Convert.ToString(Stats.food);
            yield return new WaitForSeconds(0.05f);
        }
    }
    public void cashUpdate(int a, bool b)
    {
        if (b == true)
        {
            Stats.cash -= a;
        }
        else Stats.cash += a;

        hajs.text = Convert.ToString(Stats.cash)+"$";
    }

    public void poison()
    {
        StartCoroutine(poisondmg());
    }
    IEnumerator poisondmg()
    {
        do{
            hpUpdate(1);
            yield return new WaitForSeconds(4f);
        }while (Stats.poison == true && ItemHandlerer.antidote == 0);
        if(ItemHandlerer.antidote > 0)
        {
            ItemHandlerer.antidote--;
            Stats.poison = false;
        }
    }
}
