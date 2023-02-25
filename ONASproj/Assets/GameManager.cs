using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //AI LEVELS
    public int ScubaJoeAILevel;
    public int TemporaryAILevel;
    public int ShadowAILevel;
    public int AnalJoeAILevel;

    public bool CameraOpen = false;
    public GameObject cameraOverlays;
    public AudioSource CamUp;
    //Phone guy
    public AudioSource PhoneGuy;
    public GameObject button;


    //Special rooms Audio
    public AudioSource analJoeAudio;
    public AudioSource scubaJoeAudio;
    public AudioSource temporaryAudio;
    public AudioSource secretAudio;

    public void Start()
    {
        Invoke("StartButton", 5f);
        Invoke("StopButton", 45f);
    }
    public void OpenCamera() {
        if (!CameraOpen)
        {
            if (!GameObject.FindWithTag("ShadowManager").GetComponent<ShadowBehaviour>().Done) {
                GameObject.FindWithTag("ShadowManager").GetComponent<ShadowBehaviour>().CheckShadowProb();
            }
            cameraOverlays.SetActive(true);
            CameraOpen = true;
            CamUp.Play();

            /// Special room sounds integration
            if (GameObject.FindWithTag("CamButtons").GetComponent<CamButtonsManager>().AnalJoeRoom) {
                analJoeAudio.Play();
            }
            if (GameObject.FindWithTag("CamButtons").GetComponent<CamButtonsManager>().ScubaJoeRoom) {
                scubaJoeAudio.Play();
            }
            if (GameObject.FindWithTag("CamButtons").GetComponent<CamButtonsManager>().TemporaryRoom) {
                temporaryAudio.Play();
            }
            if (GameObject.FindWithTag("CamButtons").GetComponent<CamButtonsManager>().SecretRoom) {
                secretAudio.Play();
            }
        }
        else if (CameraOpen) {
            if (GameObject.FindWithTag("ShadowManager").GetComponent<ShadowBehaviour>().ShadowActive) {
                GameObject.FindWithTag("ShadowManager").GetComponent<ShadowBehaviour>().ShadowActive = false;
            }
            cameraOverlays.SetActive(false);
            analJoeAudio.Stop();
            scubaJoeAudio.Stop();
            temporaryAudio.Stop();
            secretAudio.Stop();
            CameraOpen = false;
        }

    }
    public void StopPhoneGuy() {
        PhoneGuy.Stop();
        button.SetActive(false);
    }
    public void StartButton() {
        button.SetActive(true);
    }
    public void StopButton() {
        button.SetActive(false);
    }
}
