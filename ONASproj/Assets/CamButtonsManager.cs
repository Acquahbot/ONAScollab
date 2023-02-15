using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamButtonsManager : MonoBehaviour
{
    public GameObject AnalJoe;
    public GameObject ScubaJoe2;
    public GameObject CenterJoe;
    public GameObject Meeting;
    public GameObject Temporary;
    public GameObject VentRight;
    public GameObject VentLeft;
    public GameObject WaitingRoom;
    public AudioSource CameraChange;
    public AudioSource AnalJoeAudio;
    public bool AnalJoeRoom = false;

    public void Update()
    {
        

    }
    public void CamA1Button()
    {
        AnalJoe.SetActive(true);
        ScubaJoe2.SetActive(false);
        CenterJoe.SetActive(false);
        Meeting.SetActive(false);
        Temporary.SetActive(false);
        VentRight.SetActive(false);
        VentLeft.SetActive(false);
        WaitingRoom.SetActive(false);
        CameraChange.Play();
        AnalJoeAudio.Play();
        AnalJoeRoom = true;
        
    }
    public void CamA2Button()
    {
        AnalJoe.SetActive(false);
        ScubaJoe2.SetActive(true);
        CenterJoe.SetActive(false);
        Meeting.SetActive(false);
        Temporary.SetActive(false);
        VentRight.SetActive(false);
        VentLeft.SetActive(false);
        WaitingRoom.SetActive(false);
        CameraChange.Play();
        AnalJoeAudio.Stop();
        AnalJoeRoom = false;
    }
    public void CamA3Button()
    {
        AnalJoe.SetActive(false);
        ScubaJoe2.SetActive(false);
        CenterJoe.SetActive(false);
        Meeting.SetActive(false);
        Temporary.SetActive(true);
        VentRight.SetActive(false);
        VentLeft.SetActive(false);
        WaitingRoom.SetActive(false);
        CameraChange.Play();
        AnalJoeAudio.Stop();
        AnalJoeRoom = false;
    }
    public void CamA9Button()
    {
        AnalJoe.SetActive(false);
        ScubaJoe2.SetActive(false);
        CenterJoe.SetActive(false);
        Meeting.SetActive(false);
        Temporary.SetActive(false);
        VentRight.SetActive(true);
        VentLeft.SetActive(false);
        WaitingRoom.SetActive(false);
        CameraChange.Play();
        AnalJoeAudio.Stop();
        AnalJoeRoom = false;
    }
    public void CamA8Button()
    {
        AnalJoe.SetActive(false);
        ScubaJoe2.SetActive(false);
        CenterJoe.SetActive(false);
        Meeting.SetActive(false);
        Temporary.SetActive(false);
        VentRight.SetActive(false);
        VentLeft.SetActive(true);
        WaitingRoom.SetActive(false);
        CameraChange.Play();
        AnalJoeAudio.Stop();
        AnalJoeRoom = false;
    }
    public void CamA10Button()
    {
        AnalJoe.SetActive(false);
        ScubaJoe2.SetActive(false);
        CenterJoe.SetActive(false);
        Meeting.SetActive(true);
        Temporary.SetActive(false);
        VentRight.SetActive(false);
        VentLeft.SetActive(false);
        WaitingRoom.SetActive(false);
        CameraChange.Play();
        AnalJoeAudio.Stop();
        AnalJoeRoom = false;
    }
    public void CamA7Button()
    {
        AnalJoe.SetActive(false);
        ScubaJoe2.SetActive(false);
        CenterJoe.SetActive(false);
        Meeting.SetActive(false);
        Temporary.SetActive(false);
        VentRight.SetActive(false);
        VentLeft.SetActive(false);
        WaitingRoom.SetActive(true);
        CameraChange.Play();
        AnalJoeAudio.Stop();
        AnalJoeRoom = false;
    }
    public void CamA5Button()
    {
        AnalJoe.SetActive(false);
        ScubaJoe2.SetActive(false);
        CenterJoe.SetActive(true);
        Meeting.SetActive(false);
        Temporary.SetActive(false);
        VentRight.SetActive(false);
        VentLeft.SetActive(false);
        WaitingRoom.SetActive(false);
        CameraChange.Play();
        AnalJoeAudio.Stop();
        AnalJoeRoom = false;
    }
}
