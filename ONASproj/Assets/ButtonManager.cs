using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject StarCompletion;
    public Animator animator;
    public void StartLevel()
    {
        
        animator.SetTrigger("FadeOut");
    }
    public void OpenCustomNight() {
        SceneManager.LoadScene(4);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Update()
    {
        if (PlayerPrefs.GetInt("GameWinn") == 1){
            StarCompletion.SetActive(true);
        }
    }
    public void Start()
    {
        PlayerPrefs.SetInt("CustomNight", 0);
    }

}
