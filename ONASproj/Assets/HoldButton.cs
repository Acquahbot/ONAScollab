using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class HoldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool buttonPressed;
    public AudioSource VDMbox;
    public bool Done = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

    public void Update()
    {
        if (buttonPressed && !Done)
        {
            VDMbox.Play();
            Done = true;
        }
        else if (!buttonPressed) {
            VDMbox.Stop();
            Done = false;
        }
    }
}