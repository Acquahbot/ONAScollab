using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TemporaryBehaviour : MonoBehaviour
{
    //Timers
    public float Timer;
    public float TimerforRefill;
    public float TimeTo = 4f;
    public float TimeToRefill = 2f;

    //VDMBOX duration and subtract
    public float TemporaryFill = 100f;
    public float Subtract = 5f;

    //Stuff for jumpscare
    public GameObject PermStatic;

public void Update()
    {

        Timer += Time.deltaTime;
        TimerforRefill += Time.deltaTime;
        if (Timer > TimeTo)
        {
            TemporaryFill-=10f;
            TimeTo = Timer + 21f-GameObject.FindWithTag("GameManager").GetComponent<GameManager>().TemporaryAILevel;
        }

        if (TemporaryFill <= 0f)
        {
            JumpscareSequence();
        }
        if (TemporaryFill > 100f)
        {
            TemporaryFill = 100f;
        }

        if (GameObject.FindWithTag("HoldButton") == null) {

        }
        else if (GameObject.FindWithTag("HoldButton").GetComponent<HoldButton>().buttonPressed) {
            if (TimerforRefill > TimeToRefill) {
                if (TemporaryFill < 100f) {
                    TemporaryFill += 20f;
                }
                TimeToRefill = TimerforRefill + 1f;
            }
        }
        
    }

    public void JumpscareSequence() {
        PermStatic.SetActive(true);
    }

}
