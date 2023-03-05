using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CustomNightButtons : MonoBehaviour
{
    public TMP_Text ScubaJoeText;
    public TMP_Text AnalJoeText;
    public TMP_Text TemporaryJoeText;
    public TMP_Text ShadowJoeText;
    public Animator animator;

    //EE
    public GameObject EEobject;
    public GameObject Static;
    public AudioSource EEaudio;
    public AudioSource mainAudio;
    public void Start()
    {
        PlayerPrefs.SetInt("ScubaJoeLevel", 0);
        PlayerPrefs.SetInt("AnalJoeLevel", 0);
        PlayerPrefs.SetInt("TemporaryJoeLevel", 0);
        PlayerPrefs.SetInt("ShadowJoeLevel", 0);
        PlayerPrefs.SetInt("CustomNight", 1);
    }

    
    public void Update()
    {
        //Text Trackers
        ScubaJoeText.text = PlayerPrefs.GetInt("ScubaJoeLevel").ToString();
        AnalJoeText.text = PlayerPrefs.GetInt("AnalJoeLevel").ToString();
        TemporaryJoeText.text = PlayerPrefs.GetInt("TemporaryJoeLevel").ToString();
        ShadowJoeText.text = PlayerPrefs.GetInt("ShadowJoeLevel").ToString();
    }
    public void GoBack() {
        SceneManager.LoadScene(0);
    }
    public void StartGame() {
        if (PlayerPrefs.GetInt("ScubaJoeLevel") == 0 && PlayerPrefs.GetInt("AnalJoeLevel") == 1 && PlayerPrefs.GetInt("ShadowJoeLevel") == 2 && PlayerPrefs.GetInt("TemporaryJoeLevel") == 7)
        {
            EEobject.SetActive(true);
            EEaudio.Play();
            Static.SetActive(false);
            mainAudio.Stop();
            Invoke("QuitGame", 5f);
        }
        else {
            animator.SetTrigger("FadeOut");
        }
        
    }

    public void QuitGame() {
        Application.Quit();
    }

    //SCUBA JOE RELATED
    public void UpScubajoe()
    {
        if (PlayerPrefs.GetInt("ScubaJoeLevel") < 20) {
            PlayerPrefs.SetInt("ScubaJoeLevel", PlayerPrefs.GetInt("ScubaJoeLevel") + 1);
        }   
    }
    public void DownScubajoe()
    {
        if (PlayerPrefs.GetInt("ScubaJoeLevel") > 0) {
            PlayerPrefs.SetInt("ScubaJoeLevel", PlayerPrefs.GetInt("ScubaJoeLevel") - 1);
        }
    }
    //ANAL JOE RELATED
    public void UpAnaljoe()
    {
        if (PlayerPrefs.GetInt("AnalJoeLevel") < 20)
        {
            PlayerPrefs.SetInt("AnalJoeLevel", PlayerPrefs.GetInt("AnalJoeLevel") + 1);
        }
    }
    public void DownAnaljoe()
    {
        if (PlayerPrefs.GetInt("AnalJoeLevel") > 0)
        {
            PlayerPrefs.SetInt("AnalJoeLevel", PlayerPrefs.GetInt("AnalJoeLevel") - 1);
        }
    }
    //TEMPORARY JOE RELATED
    public void UpTemporaryjoe()
    {
        if (PlayerPrefs.GetInt("TemporaryJoeLevel") < 20)
        {
            PlayerPrefs.SetInt("TemporaryJoeLevel", PlayerPrefs.GetInt("TemporaryJoeLevel") + 1);
        }
    }
    public void DownTemporaryjoe()
    {
        if (PlayerPrefs.GetInt("TemporaryJoeLevel") > 0)
        {
            PlayerPrefs.SetInt("TemporaryJoeLevel", PlayerPrefs.GetInt("TemporaryJoeLevel") - 1);
        }
    }
    //SHADOW JOE RELATED
    public void UpShadowjoe()
    {
        if (PlayerPrefs.GetInt("ShadowJoeLevel") < 20)
        {
            PlayerPrefs.SetInt("ShadowJoeLevel", PlayerPrefs.GetInt("ShadowJoeLevel") + 1);
        }
    }
    public void DownShadowjoe()
    {
        if (PlayerPrefs.GetInt("ShadowJoeLevel") > 0)
        {
            PlayerPrefs.SetInt("ShadowJoeLevel", PlayerPrefs.GetInt("ShadowJoeLevel") - 1);
        }
    }
}
