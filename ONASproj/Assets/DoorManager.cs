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

    public void FrontalDoor() {
        if (!FrontalDoorClosed)
        {
            FrontalDoorPref.SetActive(true);
            FrontalDoorClosed = true;
        }
        else {
            FrontalDoorPref.SetActive(false);
            FrontalDoorClosed = false;
        }
    }
    public void RightVent()
    {
        if (!RightVentClosed)
        {
            RightVentPref.SetActive(true);
            RightVentClosed = true;
        }
        else
        {
            RightVentPref.SetActive(false);
            RightVentClosed = false;
        }
    }
    public void LeftVent()
    {
        if (!LeftVentClosed)
        {
            LeftVentPref.SetActive(true);
            LeftVentClosed = true;
        }
        else
        {
            LeftVentPref.SetActive(false);
            LeftVentClosed = false;
        }
    }
}
