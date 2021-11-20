using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFlute : MonoBehaviour
{
    public Animator animator;
    public GameObject g;


    void Update()
    {
        if(AnimationIdi.playingFlute == true)
        {
            animator.SetBool("playin", true);
            StartCoroutine(wait());
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
        animator.SetBool("playin", false);
        AnimationIdi.playingFlute = false;
    }
}
