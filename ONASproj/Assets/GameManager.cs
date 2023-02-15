using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool CameraOpen = false;
    public GameObject cameraOverlays;

    public void OpenCamera() {
        if (!CameraOpen)
        {
            cameraOverlays.SetActive(true);
            CameraOpen = true;
        }
        else if (CameraOpen) {
            cameraOverlays.SetActive(false);
            CameraOpen = false;
        }
    }
}
