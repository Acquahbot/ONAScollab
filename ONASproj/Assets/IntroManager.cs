using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    public Animator animator;

    public void Start()
    {
        Invoke("StartFadeOut", 4f);
    }
    // Update is called once per frame
    public void StartFadeOut() {
        animator.SetTrigger("FadeOut");
    }
}
