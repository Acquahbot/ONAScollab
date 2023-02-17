using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int ScubaJoeAILevel;
    public bool CameraOpen = false;
    public GameObject cameraOverlays;
    public AudioSource CamUp;
    public AudioSource analJoeAudio;
    public AudioSource scubaJoeAudio;
    public AudioSource temporaryAudio;
    public AudioSource secretAudio;

    public void OpenCamera() {
        if (!CameraOpen)
        {
            cameraOverlays.SetActive(true);
            CameraOpen = true;
            CamUp.Play();
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

            cameraOverlays.SetActive(false);
            analJoeAudio.Stop();
            scubaJoeAudio.Stop();
            temporaryAudio.Stop();
            secretAudio.Stop();
            CameraOpen = false;
        }
    }
}
