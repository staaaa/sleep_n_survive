using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopHandlerer : MonoBehaviour
{

    public GameObject tree;
    public GameObject antidote;
    public GameObject juice;
    public GameObject wood;
    public GameObject Flute;
    public GameObject kwiatki;
    public GameObject miod;

    public StatsUpdater st;
    

    public GameObject poisonIndicator;

    public void LemonTree()
    {
        if(ItemHandlerer.lemontree == 0 && Stats.cash >= 13)
        {
            tree.transform.position = new Vector2(-1.18f, -0.53f);
            st.cashUpdate(13, true);
            ItemHandlerer.lemontree++;
        } 
    }
    public void Antidote()
    {
        if (ItemHandlerer.antidote == 0 && Stats.cash >= 30)
        {
            antidote.transform.position = new Vector2(-0.8f, -0.82f);
            st.cashUpdate(30, true);
            ItemHandlerer.antidote = 3;
        }
    }
    public void TomatoJuice()
    {
        if(ItemHandlerer.TomatoJuice == 0 && Stats.cash >= 20)
        {
            juice.transform.position = new Vector2(-0.8f, -0.82f);
            st.cashUpdate(20, true);
            if (Stats.smrod == true)
            {
                ItemHandlerer.TomatoJuice = 2;
                Stats.smrod = false;
            }
            else ItemHandlerer.TomatoJuice = 3;
        }
    }
    public void Wood()
    {
        if(ItemHandlerer.Wood == 0 && Stats.cash >= 50)
        {
            wood.transform.position = new Vector2(-1.15f, -0.1f);
            st.cashUpdate(50, true);
            ItemHandlerer.Wood = 5;
        }
    }
    public void flute()
    {
        if (ItemHandlerer.Flute == 0 && Stats.cash >= 69)
        {
            Flute.transform.position = new Vector2(0.044f, -1.05f);
            st.cashUpdate(69, true);
            ItemHandlerer.Flute = 3;
        }
    }
    public void flowers()
    {
        if(ItemHandlerer.flowers == 0 && Stats.cash >= 11)
        {
            kwiatki.transform.position = new Vector2(0.55f, -0.332f);
            st.cashUpdate(11, true);
            ItemHandlerer.flowers = 5;
        }
    }
    public void honey()
    {
        if(ItemHandlerer.honey == 0 && Stats.cash >= 50)
        {
            miod.transform.position = new Vector2(-1.071f, -0.758f);
            st.cashUpdate(50, true);
            ItemHandlerer.honey = 2;
        }
    }
}
