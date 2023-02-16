using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public bool FrontalDoorClosed = false;
    public GameObject FrontalDoorPref;

    public bool RightVentClosed = false;
    public GameObject RightVentPref;

    public bool LeftVentClosed = false;
    public GameObject LeftVentPref;
    public bool AddedNumber = false;

    public AudioSource DoorClosing;
    public AudioSource DoorOpening;

    public int NumberOfClosedDoors = 0;

    public void Update()
    {
        if (GameObject.FindWithTag("GameManager").GetComponent<GameManager>().CameraOpen && !AddedNumber)
        {
            NumberOfClosedDoors++;
            AddedNumber = true;
        }
        else if (!GameObject.FindWithTag("GameManager").GetComponent<GameManager>().CameraOpen && AddedNumber)
        {
            NumberOfClosedDoors--;
            AddedNumber = false;
        }
    }

    public void FrontalDoor() {
        if (!FrontalDoorClosed)
        {
            FrontalDoorPref.SetActive(true);
            FrontalDoorClosed = true;
            NumberOfClosedDoors++;
            DoorClosing.Play();
        }
        else {
            FrontalDoorPref.SetActive(false);
            FrontalDoorClosed = false;
            NumberOfClosedDoors--;
            DoorOpening.Play();
        }
    }
    public void RightVent()
    {
        if (!RightVentClosed)
        {
            RightVentPref.SetActive(true);
            RightVentClosed = true;
            NumberOfClosedDoors++;
            DoorClosing.Play();
        }
        else
        {
            RightVentPref.SetActive(false);
            RightVentClosed = false;
            NumberOfClosedDoors--;
            DoorOpening.Play();
        }
    }
    public void LeftVent()
    {
        if (!LeftVentClosed)
        {
            LeftVentPref.SetActive(true);
            LeftVentClosed = true;
            NumberOfClosedDoors++;
            DoorClosing.Play();
        }
        else
        {
            LeftVentPref.SetActive(false);
            LeftVentClosed = false;
            NumberOfClosedDoors--;
            DoorOpening.Play();
        }
    }
}
