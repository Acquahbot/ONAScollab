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

    public bool LockDoors = false;

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
        if (!FrontalDoorClosed  && !LockDoors)
        {
            FrontalDoorPref.SetActive(true);
            FrontalDoorClosed = true;
            NumberOfClosedDoors++;
            DoorClosing.Play();
        }
        else if(!LockDoors){
            FrontalDoorPref.SetActive(false);
            FrontalDoorClosed = false;
            NumberOfClosedDoors--;
            DoorOpening.Play();
        }
    }
    public void RightVent()
    {
        if (!RightVentClosed && !LockDoors)
        {
            RightVentPref.SetActive(true);
            RightVentClosed = true;
            NumberOfClosedDoors++;
            DoorClosing.Play();
        }
        else if(!LockDoors)
        {
            RightVentPref.SetActive(false);
            RightVentClosed = false;
            NumberOfClosedDoors--;
            DoorOpening.Play();
        }
    }
    public void LeftVent()
    {
        if (!LeftVentClosed && !LockDoors)
        {
            LeftVentPref.SetActive(true);
            LeftVentClosed = true;
            NumberOfClosedDoors++;
            DoorClosing.Play();
        }
        else if(!LockDoors)
        {
            LeftVentPref.SetActive(false);
            LeftVentClosed = false;
            NumberOfClosedDoors--;
            DoorOpening.Play();
        }
    }

    public void OpenDoorsOffice() {
        if (FrontalDoorClosed) {
            FrontalDoor();
        }
        if (RightVentClosed) {
            RightVent();
        }
        if (LeftVentClosed) {
            LeftVent();
        }
        Invoke("LockDoorsChange", 0.2f);
    }
    public void LockDoorsChange() {
        if (!LockDoors)
        {
            LockDoors = true;
        }
        else if(LockDoors){
            LockDoors = false;
        }
    }
}
