using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnalJoeBehaviour : MonoBehaviour
{
    //Scubajoe Rooms
    public GameObject AnalState1;
    public GameObject AnalState2;
    public GameObject AnalState3;
    //Waiting rooms
    public GameObject WaitingState1;
    public GameObject WaitingState2;
    //Meeting rooms
    public GameObject MeetingState1;
    public GameObject MeetingState2;
    //leftVent
    public GameObject LeftVentState1;
    public GameObject LeftVentState2;
    //rightVent
    public GameObject RightVentState1;
    public GameObject RightVentState2;
    //States
    public bool AnalJoe1= true;
    public bool AnalJoe2= false;

    public bool Waiting = false;
    public bool Meeting = false;
    public bool leftVent = false;
    public bool rightVent = false;
    public bool Ending = false;
    public bool GoJump = false;

    // AILEVEL
    public int AiLevel;

    //Timers
    public float Timer;
    public float TimeTo = 4f;
    public float TimerRand;
    public float TimeToRand = 2f;
    public int Random2;
    public int StoreVent = 0;
    //left Vent 1
    //right Vent 2

    //bools n stuff
    public bool Done = false;
    public bool Done2 = false;
    public float TimeBeforejumpScare = 7f;
    public AudioSource analJumpscare;
    public GameObject analJumpscareAnim;
    public GameObject FullStatic;
    public GameObject MeetingStatic;
    public GameObject WaitingStatic;
    public GameObject leftVentStatic;
    public GameObject rightVentStatic;
    public Animator CamShakeAnimator;


    public void Update()
    {
        // RANDOMIZED AI FOR CAM MOVEMENTS.
        Timer += Time.deltaTime;
        TimerRand += Time.deltaTime;
        if (TimerRand > TimeToRand) {
            Random2 = Random.Range(1, 3);
            TimeToRand = TimerRand + 2f;
        }
        if (Timer > TimeTo)
        {
            int Rand = Random.Range(0, 21);
            if (AiLevel > Rand)
            {
                if (AnalJoe1 && !Done)
                {
                    AnalJoe1 = false;
                    AnalJoe2 = true;
                    Done = true;
                    StaticOn();
                    Invoke("StaticOff", 0.7f);
                }
                if (AnalJoe2 && !Done)
                {
                    AnalJoe2 = false;
                    if (Random2 == 1)
                    {
                        Waiting = true;
                        StaticOnWaiting();
                        Invoke("StaticOffWaiting", 0.7f);
                    }
                    else if (Random2 == 2) {
                        Meeting = true;
                        StaticOnMeeting();
                        Invoke("StaticOffMeeting", 0.7f);
                    }
                    Done = true;
                    StaticOn();
                    Invoke("StaticOff", 0.7f);
                    
                }
                if (Meeting && !Done)
                {
                    StaticOnMeeting();
                    Invoke("StaticOffMeeting", 0.7f);
                    StaticOnRight();
                    Invoke("StaticOffRight", 0.7f);
                    Meeting = false;
                    Waiting = false;
                    leftVent = true;
                    Done = true;
                }
                if (Waiting && !Done)
                {
                    StaticOnWaiting();
                    Invoke("StaticOffWaiting", 0.7f);
                    StaticOnLeft();
                    Invoke("StaticOffLeft", 0.7f);
                    Meeting = false;
                    Waiting = false;
                    rightVent= true;
                    Done = true;
                }
                if (leftVent && !Done)
                {
                    StaticOnLeft();
                    StoreVent = 1;
                    Invoke("StaticOffLeft", 0.7f);
                    leftVent = false;
                    Ending = true;
                    Done = true;
                }
                if (rightVent && !Done)
                {
                    StaticOnRight();
                    StoreVent = 2;
                    Invoke("StaticOffRight", 0.7f);
                    rightVent = false;
                    Ending = true;
                    Done = true;
                }
            }
            Done = false;
            TimeTo = Timer + 8f;
            
        }



        //Ending Phase of his movement
        if (Ending && !Done2)
        {
            if (StoreVent == 1 && !GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().LeftVentClosed)
            {
                JumpscareSequence();
                Done2 = true;
            }
            else if (StoreVent == 2 && !GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().RightVentClosed)
            {
                JumpscareSequence();
                Done2 = true;
            }
            else {
                if (StoreVent == 1)
                {
                    StaticOnLeft();
                    Invoke("StaticOffLeft", 0.7f);
                }
                else if (StoreVent == 2) {
                    StaticOnRight();
                    Invoke("StaticOffRight", 0.7f);
                }
                Ending = false;
                AnalJoe1 = true;
                Done2 = false;
                StaticOn();
                Invoke("StaticOff", 0.7f);
            }
        }

        //////////////
        //nevertouch//
        //////////////

        AiLevel = GameObject.FindWithTag("GameManager").GetComponent<GameManager>().AnalJoeAILevel;
        if (AnalJoe1)
        {
            AnalState1.SetActive(true);
            AnalState2.SetActive(false);
            AnalState3.SetActive(false);
            WaitingState1.SetActive(true);
            WaitingState2.SetActive(false);
            MeetingState1.SetActive(true);
            MeetingState2.SetActive(false);
            LeftVentState1.SetActive(true);
            LeftVentState2.SetActive(false);
            RightVentState1.SetActive(true);
            RightVentState2.SetActive(false);
            
}
        if (AnalJoe2)
        {
            AnalState1.SetActive(false);
            AnalState2.SetActive(true);
            AnalState3.SetActive(false);
            WaitingState1.SetActive(true);
            WaitingState2.SetActive(false);
            MeetingState1.SetActive(true);
            MeetingState2.SetActive(false);
            LeftVentState1.SetActive(true);
            LeftVentState2.SetActive(false);
            RightVentState1.SetActive(true);
            RightVentState2.SetActive(false);
        }
        if (Meeting)
        {
            AnalState1.SetActive(false);
            AnalState2.SetActive(false);
            AnalState3.SetActive(true);
            WaitingState1.SetActive(true);
            WaitingState2.SetActive(false);
            MeetingState1.SetActive(false);
            MeetingState2.SetActive(true);
            LeftVentState1.SetActive(true);
            LeftVentState2.SetActive(false);
            RightVentState1.SetActive(true);
            RightVentState2.SetActive(false);
        }
        if (Waiting)
        {
            AnalState1.SetActive(false);
            AnalState2.SetActive(false);
            AnalState3.SetActive(true);
            WaitingState1.SetActive(false);
            WaitingState2.SetActive(true);
            MeetingState1.SetActive(true);
            MeetingState2.SetActive(false);
            LeftVentState1.SetActive(true);
            LeftVentState2.SetActive(false);
            RightVentState1.SetActive(true);
            RightVentState2.SetActive(false);
        }
        if (leftVent)
        {
            AnalState1.SetActive(false);
            AnalState2.SetActive(false);
            AnalState3.SetActive(true);
            WaitingState1.SetActive(true);
            WaitingState2.SetActive(false);
            MeetingState1.SetActive(true);
            MeetingState2.SetActive(false);
            LeftVentState1.SetActive(false);
            LeftVentState2.SetActive(true);
            RightVentState1.SetActive(true);
            RightVentState2.SetActive(false);
        }
        if (rightVent)
        {
            AnalState1.SetActive(false);
            AnalState2.SetActive(false);
            AnalState3.SetActive(true);
            WaitingState1.SetActive(true);
            WaitingState2.SetActive(false);
            MeetingState1.SetActive(true);
            MeetingState2.SetActive(false);
            LeftVentState1.SetActive(true);
            LeftVentState2.SetActive(false);
            RightVentState1.SetActive(false);
            RightVentState2.SetActive(true);
        }
        if (Ending)
        {
            AnalState1.SetActive(false);
            AnalState2.SetActive(false);
            AnalState3.SetActive(true);
            WaitingState1.SetActive(true);
            WaitingState2.SetActive(false);
            MeetingState1.SetActive(true);
            MeetingState2.SetActive(false);
            LeftVentState1.SetActive(true);
            LeftVentState2.SetActive(false);
            RightVentState1.SetActive(true);
            RightVentState2.SetActive(false);
        }
    }
    
    public void JumpscareSequence()
    {
            //Jumpscare
            Debug.Log("You Died from AnalJoe");
            Ending = false;
            AnalJoe1 = true;
            analJumpscare.Play();
            //GameObject.FindWithTag("MainCamera").GetComponent<CameraLook>().Cameralocked = true;
            if (GameObject.FindWithTag("GameManager").GetComponent<GameManager>().CameraOpen)
            {
                GameObject.FindWithTag("GameManager").GetComponent<GameManager>().OpenCamera();
            }

            analJumpscareAnim.SetActive(true);
            CamShakeAnimator.SetTrigger("Shake");
            Invoke("Deathscreen", 0.7f);

            Done2 = false;
    }

    public void Deathscreen()
    {
        SceneManager.LoadScene(2);
    }

    //Statics for cam movements do not touch
    public void StaticOn()
    {
        FullStatic.SetActive(true);
    }
    public void StaticOff()
    {
        FullStatic.SetActive(false);
    }

    public void StaticOnWaiting()
    {
        WaitingStatic.SetActive(true);
    }
    public void StaticOffWaiting()
    {
        WaitingStatic.SetActive(false);
    }
    public void StaticOnMeeting()
    {
        MeetingStatic.SetActive(true);
    }
    public void StaticOffMeeting()
    {
        MeetingStatic.SetActive(false);
    }

    public void StaticOnLeft()
    {
        leftVentStatic.SetActive(true);
    }
    public void StaticOffLeft()
    {
        leftVentStatic.SetActive(false);
    }
    public void StaticOnRight()
    {
        rightVentStatic.SetActive(true);
    }
    public void StaticOffRight()
    {
        rightVentStatic.SetActive(false);
    }
}
