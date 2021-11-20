using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NightHandler: MonoBehaviour
{
    // Start is called before the first frame update

    public void Wave()
    {
        StartCoroutine(Fala());
    }
    IEnumerator Fala()
    {
        FindObjectOfType<Bee>().BeeMove();
        yield return new WaitForSeconds(3f);

        FindObjectOfType<Bee>().BeeMove();
        yield return new WaitForSeconds(3f);

        FindObjectOfType<Bee>().BeeMove();
        yield return new WaitForSeconds(3f);

        FindObjectOfType<Bee>().BeeMove();
        yield return new WaitForSeconds(3f);

        FindObjectOfType<Bee>().BeeMove();
        yield return new WaitForSeconds(3f);

        FindObjectOfType<Bee>().BeeMove();
        yield return new WaitForSeconds(3f);

        FindObjectOfType<Snake>().SnakeMove();
        if(ItemHandlerer.Flute > 0)
        {
            yield return new WaitForSeconds(8f);
        }
        else yield return new WaitForSeconds(4f);

        FindObjectOfType<Snake>().SnakeMove();
        if (ItemHandlerer.Flute > 0)
        {
            yield return new WaitForSeconds(8f);
        }
        else yield return new WaitForSeconds(4f);

        FindObjectOfType<Snake>().SnakeMove();
        if(ItemHandlerer.Flute > 0)
        {
            yield return new WaitForSeconds(8f);
        }
        else yield return new WaitForSeconds(4f);

        FindObjectOfType<Snake>().SnakeMove();
        if (ItemHandlerer.Flute > 0)
        {
            yield return new WaitForSeconds(8f);
        }
        else yield return new WaitForSeconds(4f);

        FindObjectOfType<Skunk>().SkunkMove();
        yield return new WaitForSeconds(8f);

        //FindObjectOfType<Snake>().SnakeMove();
        //yield return new WaitForSeconds(4f);

        //FindObjectOfType<Bee>().BeeMove();
        //yield return new WaitForSeconds(3f);

        FindObjectOfType<Woodpecker>().BirdMove();
        yield return new WaitForSeconds(10f);
    }

    void Update()
    {
        if (Stats.hp <= 0)
        {
            SceneManager.LoadScene("Dead");
        }
    }
}
