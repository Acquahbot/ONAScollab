using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public Animator animator;
    public void StartLevel()
    {
        
        animator.SetTrigger("FadeOut");
    }
    public void Quit()
    {
        Application.Quit();
    }

    
}
