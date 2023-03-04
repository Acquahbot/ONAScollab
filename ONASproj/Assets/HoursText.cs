using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using TMPro;

public class HoursText : MonoBehaviour
{
    public TMP_Text hoursText;
    public bool GameWon = false;
    public VideoPlayer WinVideo;
    public GameObject imageWinVideo;
    public AudioSource[] Audios;
    public GameObject[] Everything;

    public void Start()
    {
        //CustomNight
        if (PlayerPrefs.GetInt("CustomNight") == 1)
        {
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ScubaJoeAILevel = PlayerPrefs.GetInt("ScubaJoeLevel");
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().TemporaryAILevel = PlayerPrefs.GetInt("TemporaryJoeLevel");
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().AnalJoeAILevel = PlayerPrefs.GetInt("AnalJoeLevel");
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ShadowAILevel = PlayerPrefs.GetInt("ShadowJoeLevel");
        }
        Invoke("AM1", 120f);
        Invoke("AM2", 240f);
        Invoke("AM3", 360f);
        Invoke("AM4", 480f);
        Invoke("AM5", 600f);
        Invoke("AM6", 720f);
    }




    /// /////// ///
    /// Invokes /// 
    /// /////// ///

    public void AM1() {
        hoursText.text = "1 AM";
        if (PlayerPrefs.GetInt("CustomNight") == 0)
        {
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ScubaJoeAILevel = 6;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().TemporaryAILevel = 4;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().AnalJoeAILevel = 3;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ShadowAILevel = 0;
        }
        
    }
    public void AM2()
    {
        if (PlayerPrefs.GetInt("CustomNight") == 0){
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ScubaJoeAILevel = 10;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().TemporaryAILevel = 8;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().AnalJoeAILevel = 8;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ShadowAILevel = 4;
        }
        hoursText.text = "2 AM";
        
    }
    public void AM3()
    {
        if (PlayerPrefs.GetInt("CustomNight") == 0){
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ScubaJoeAILevel = 12;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().TemporaryAILevel = 12;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().AnalJoeAILevel = 10;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ShadowAILevel = 10;
        }
        hoursText.text = "3 AM";
        
    }
    public void AM4()
    {
        if (PlayerPrefs.GetInt("CustomNight") == 0){
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ScubaJoeAILevel = 16;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().TemporaryAILevel = 15;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().AnalJoeAILevel = 15;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ShadowAILevel = 14;
        }
            hoursText.text = "4 AM";
        
    }
    public void AM5()
    {
        if (PlayerPrefs.GetInt("CustomNight") == 0) {
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ScubaJoeAILevel = 18;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().TemporaryAILevel = 15;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().AnalJoeAILevel = 16;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ShadowAILevel = 15;
        }
        hoursText.text = "5 AM";
        
    }
    public void AM6()
    {
        hoursText.text = "6 AM";
        WinVideo.Play();
        imageWinVideo.SetActive(true);
        GameWon = true;
        if (PlayerPrefs.GetInt("CustomNight") == 1)
        {

        }
        else {
            PlayerPrefs.SetInt("GameWinn", 1);
        }
        Invoke("GoBacktoMain", 29f);
        
    }
    public void Update()
    {
        if (GameWon) {
            for (int i = 0; i < Audios.Length; i++)
            {
                Audios[i].Stop();
            }
            for (int i = 0; i < Everything.Length; i++)
            {
                Everything[i].SetActive(false);
            }
        }
    }
    public void GoBacktoMain() {
        SceneManager.LoadScene(0);
    }


}
