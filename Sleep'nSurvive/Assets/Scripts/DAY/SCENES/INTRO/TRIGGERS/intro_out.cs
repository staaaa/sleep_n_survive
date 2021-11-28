using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro_out : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        fade_static.trigger = true;
        fade_static.fade = false;
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Forest 1");
    }
}
