using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HoursText : MonoBehaviour
{
    public TMP_Text hoursText;
    public bool GameWon = false;

    public void Start()
    {
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
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ScubaJoeAILevel = 6;
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().TemporaryAILevel = 4;
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().AnalJoeAILevel = 3;
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ShadowAILevel = 0;
    }
    public void AM2()
    {
        hoursText.text = "2 AM";
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ScubaJoeAILevel = 10;
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().TemporaryAILevel = 8;
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().AnalJoeAILevel = 8;
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ShadowAILevel = 4;
    }
    public void AM3()
    {
        hoursText.text = "3 AM";
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ScubaJoeAILevel = 12;
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().TemporaryAILevel = 12;
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().AnalJoeAILevel = 10;
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ShadowAILevel = 10;
    }
    public void AM4()
    {
        hoursText.text = "4 AM";
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ScubaJoeAILevel = 16;
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().TemporaryAILevel = 15;
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().AnalJoeAILevel = 15;
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ShadowAILevel = 14;
    }
    public void AM5()
    {
        hoursText.text = "5 AM";
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ScubaJoeAILevel = 18;
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().TemporaryAILevel = 15;
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().AnalJoeAILevel = 16;
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ShadowAILevel = 15;
    }
    public void AM6()
    {
        hoursText.text = "6 AM";
        GameWon = true;
    }


}
