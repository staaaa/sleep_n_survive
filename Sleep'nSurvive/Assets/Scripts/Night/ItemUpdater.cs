using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUpdater : MonoBehaviour
{
    public GameObject poisonIndicator;
    public GameObject smrodIndicator;

    public GameObject antidote;
    public GameObject juice;
    public GameObject wood;
    public GameObject Flute;
    public GameObject flowers;
    public GameObject honey;

    void Update()
    {
        if (Stats.poison == true)
        {
            poisonIndicator.transform.position = new Vector2(-1.5f, 0.75f);
        }
        else if (Stats.poison == false)
        {
            poisonIndicator.transform.position = new Vector2(5.5f, 0.75f);
        }

        if (ItemHandlerer.antidote > 0)
        {
            antidote.transform.position = new Vector2(-0.8f, -0.82f);
        }
        else if (ItemHandlerer.antidote == 0)
        {
            antidote.transform.position = new Vector2(3.6f, -0.82f);
        }

        if (Stats.smrod == true)
        {
            smrodIndicator.transform.position = new Vector2(-1.5f,0.38f);
        }
        else if (Stats.smrod == false)
        {
            smrodIndicator.transform.position = new Vector2(3.6f, 0.38f);
        }
        if (ItemHandlerer.TomatoJuice > 0)
        {
            juice.transform.position = new Vector2(0.15f, -0.7f);
        }
        else if (ItemHandlerer.TomatoJuice == 0)
        {
            juice.transform.position = new Vector2(3.6f, 0.38f);
        }
        if (ItemHandlerer.Wood == 0)
        {
            wood.transform.position = new Vector2(-8f, -0.105f);
        }
        if(ItemHandlerer.Flute == 0)
        {
            Flute.transform.position = new Vector2(-5.14f, -1.022f);
        }
        if(ItemHandlerer.flowers == 0)
        {
            flowers.transform.position = new Vector2(-4.33f, -0.332f);
        }
        if(ItemHandlerer.honey == 0)
        {
            honey.transform.position = new Vector2(-5.26f, -0.758f);
        }
    }
}
