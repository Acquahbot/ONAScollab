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
    public GameObject Secret;

    //Audio
    public AudioSource CameraChange;
    public AudioSource AnalJoeAudio;
    public AudioSource ScubaJoeAudio;
    public AudioSource TemporaryJoeAudio;
    public AudioSource SecretAudio;
    public bool AnalJoeRoom = false;
    public bool ScubaJoeRoom = false;
    public bool TemporaryRoom = false;
    public bool SecretRoom = false;
    public void Update()
    {
        

    }
    // Anal Room
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
        ScubaJoeAudio.Stop();
        TemporaryJoeAudio.Stop();
        AnalJoeRoom = true;
        ScubaJoeRoom = false;
        TemporaryRoom = false;
    }
    // Scuba Room
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
        TemporaryJoeAudio.Stop();
        ScubaJoeAudio.Play();
        AnalJoeRoom = false;
        ScubaJoeRoom = true;
        TemporaryRoom = false;
    }
    // Temporary Room
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
        ScubaJoeAudio.Stop();
        TemporaryJoeAudio.Play();
        AnalJoeRoom = false;
        ScubaJoeRoom = false;
        TemporaryRoom = true;
    }
    // Vent Right
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
        ScubaJoeAudio.Stop();
        TemporaryJoeAudio.Stop();
        AnalJoeRoom = false;
        ScubaJoeRoom = false;
        TemporaryRoom = false;
    }
    // Vent Left
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
        ScubaJoeAudio.Stop();
        TemporaryJoeAudio.Stop();
        AnalJoeRoom = false;
        ScubaJoeRoom = false;
        TemporaryRoom = false;
    }
    // Waiting Room
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
        ScubaJoeAudio.Stop();
        TemporaryJoeAudio.Stop();
        AnalJoeRoom = false;
        ScubaJoeRoom = false;
        TemporaryRoom = false;
    }
    // Meeting Room
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
        //SecretRoom.SetActive(false);
        CameraChange.Play();
        AnalJoeAudio.Stop();
        ScubaJoeAudio.Stop();
        TemporaryJoeAudio.Stop();
        AnalJoeRoom = false;
        ScubaJoeRoom = false;
        TemporaryRoom = false;
    }
    // Center Room
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
        //SecretRoom.SetActive(false);
        CameraChange.Play();
        AnalJoeAudio.Stop();
        ScubaJoeAudio.Stop();
        TemporaryJoeAudio.Stop();
        AnalJoeRoom = false;
        ScubaJoeRoom = false;
        TemporaryRoom = false;
    }
    public void CamA6Button()
    {
        AnalJoe.SetActive(false);
        ScubaJoe2.SetActive(false);
        CenterJoe.SetActive(false);
        Meeting.SetActive(false);
        Temporary.SetActive(false);
        VentRight.SetActive(false);
        VentLeft.SetActive(false);
        WaitingRoom.SetActive(false);
        //SecretRoom.SetActive(true);
        CameraChange.Play();
        AnalJoeAudio.Stop();
        ScubaJoeAudio.Stop();
        TemporaryJoeAudio.Stop();
        AnalJoeRoom = false;
        ScubaJoeRoom = true;
        TemporaryRoom = false;
    }
}
