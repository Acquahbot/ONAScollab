using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool CameraOpen = false;
    public GameObject cameraOverlays;
    public AudioSource CamUp;
    public AudioSource analJoeAudio;
    public int ScubaJoeAILevel;

    public void OpenCamera() {
        if (!CameraOpen)
        {
            cameraOverlays.SetActive(true);
            CameraOpen = true;
            CamUp.Play();
            if (GameObject.FindWithTag("CamButtons").GetComponent<CamButtonsManager>().AnalJoeRoom) {
                analJoeAudio.Play();
            }

        }
        else if (CameraOpen) {
            cameraOverlays.SetActive(false);
            analJoeAudio.Stop();
            CameraOpen = false;
        }
    }



}
