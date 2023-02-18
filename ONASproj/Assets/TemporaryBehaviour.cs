using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TemporaryBehaviour : MonoBehaviour
{
    public float Timer;
    public float TimerforRefill;
    public float TimeTo = 4f;
    public float TimeToRefill = 2f;

    public float TemporaryFill = 100f;
    public float Subtract = 5f;

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
            Debug.Log("You died from Temporary");
        }
        if (TemporaryFill > 100f)
        {
            TemporaryFill = 99f;
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

}
