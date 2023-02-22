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

    //States
    public bool AnalJoe1= true;
    public bool AnalJoe2= false;

    public bool Waiting = false;
    public bool Meeting = false;
    public bool Ending = false;

    // AILEVEL
    public int AiLevel;

    //Timers
    public float Timer;
    public float TimeTo = 4f;

    //bools n stuff
    public bool Done = false;
    public bool Done2 = false;
    public float TimeBeforejumpScare = 7f;
    public AudioSource scubaJumpscare;
    public GameObject scubaJumpscareAnim;
    public GameObject FullStatic;
    public GameObject FullStaticCentre;


    public void Update()
    {
        // RANDOMIZED AI FOR CAM MOVEMENTS.
        Timer += Time.deltaTime;
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
                if (AnalJoe1 && !Done)
                {
                    AnalJoe2 = false;
                    if (Random.Range(1, 2) == 1)
                    {
                        Waiting = true;
                    }
                    else if (Random.Range(1, 2) == 2) {
                        Meeting = true;
                    }
                    Done = true;
                    StaticOn();
                    Invoke("StaticOff", 0.7f);
                    StaticOn2();
                    Invoke("StaticOff2", 0.7f);
                }
                if (Waiting && !Done)
                {
                    StaticOn2();
                    Invoke("StaticOff2", 0.7f);
                    Meeting = false;
                    Waiting = false;
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
            Done2 = true;
            Invoke("JumpscareCheck", TimeBeforejumpScare);
        }

        //////////////
        //nevertouch//
        //////////////

        AiLevel = GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ScubaJoeAILevel;
        if (AnalJoe1)
        {
            AnalState1.SetActive(true);
            AnalState2.SetActive(false);
            AnalState3.SetActive(false);
            WaitingState1.SetActive(true);
            WaitingState2.SetActive(false);
            MeetingState1.SetActive(true);
            MeetingState2.SetActive(false);
            LeftVentState1.SetActive(false);
            LeftVentState2.SetActive(false);
}
        if (AnalJoe2)
        {
            AnalState1.SetActive(true);
            AnalState2.SetActive(false);
            AnalState3.SetActive(false);
            WaitingState1.SetActive(true);
            WaitingState2.SetActive(false);
            MeetingState1.SetActive(true);
            MeetingState2.SetActive(false);
            LeftVentState1.SetActive(false);
            LeftVentState2.SetActive(false);
        }
        if (Meeting)
        {
            AnalState1.SetActive(true);
            AnalState2.SetActive(false);
            AnalState3.SetActive(false);
            WaitingState1.SetActive(true);
            WaitingState2.SetActive(false);
            MeetingState1.SetActive(true);
            MeetingState2.SetActive(false);
            LeftVentState1.SetActive(false);
            LeftVentState2.SetActive(false);
        }
        if (Waiting)
        {
            AnalState1.SetActive(true);
            AnalState2.SetActive(false);
            AnalState3.SetActive(false);
            WaitingState1.SetActive(true);
            WaitingState2.SetActive(false);
            MeetingState1.SetActive(true);
            MeetingState2.SetActive(false);
            LeftVentState1.SetActive(false);
            LeftVentState2.SetActive(false);
        }
        if (Ending)
        {
            AnalState1.SetActive(true);
            AnalState2.SetActive(false);
            AnalState3.SetActive(false);
            WaitingState1.SetActive(true);
            WaitingState2.SetActive(false);
            MeetingState1.SetActive(true);
            MeetingState2.SetActive(false);
            LeftVentState1.SetActive(false);
            LeftVentState2.SetActive(false);
        }
    }

    public void JumpscareCheck()
    {
        if (!GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().FrontalDoorClosed)
        {
            //Jumpscare
            Debug.Log("You Died from Scuba joe");
            Ending = false;
            AnalJoe1 = true;
            scubaJumpscare.Play();
            GameObject.FindWithTag("MainCamera").GetComponent<CameraLook>().Cameralocked = true;
            if (GameObject.FindWithTag("GameManager").GetComponent<GameManager>().CameraOpen)
            {
                GameObject.FindWithTag("GameManager").GetComponent<GameManager>().OpenCamera();
            }

            scubaJumpscareAnim.SetActive(true);
            Invoke("Deathscreen", 0.7f);

            Done2 = false;
        }
        else
        {
            Ending = false;
            AnalJoe1 = true;
            Done2 = false;
            StaticOn();
            Invoke("StaticOff", 0.7f);
        }
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

    public void StaticOn2()
    {
        FullStaticCentre.SetActive(true);
    }
    public void StaticOff2()
    {
        FullStaticCentre.SetActive(false);
    }
}
