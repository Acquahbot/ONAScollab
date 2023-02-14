using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject CameraOverlay;
    public bool CameraOpen = false;
    public TMP_Text HourText;
    public bool survived = false;

    public void Start()
    {
        Invoke("AM1", 120f);
        Invoke("AM2", 240f);
        Invoke("AM3", 360f);
        Invoke("AM4", 480f);
        Invoke("AM5", 600f);
        Invoke("AM6", 720f);
    }
    public void AM1() {
        HourText.text = "1 AM";
    }
    public void AM2()
    {
        HourText.text = "2 AM";
    }
    public void AM3()
    {
        HourText.text = "3 AM";
    }
    public void AM4()
    {
        HourText.text = "4 AM";
    }
    public void AM5()
    {
        HourText.text = "5 AM";
    }
    public void AM6()
    {
        HourText.text = "6 AM";
        survived = true;
    }

    public void OpenOverlay() {
        if (!CameraOpen)
        {
            CameraOverlay.SetActive(true);
            CameraOpen = true;
        }
        else if (CameraOpen)
        {
            CameraOverlay.SetActive(false);
            CameraOpen = false;
        }
        
    }

    
}
