using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScubaJoeBehaviour : MonoBehaviour
{
    //Scubajoe Rooms
    public GameObject ScubaJoeState1;
    public GameObject ScubaJoeState2;
    public GameObject ScubaJoeState3;
    //Center rooms
    public GameObject CenterState1;
    public GameObject CenterState2;

    //States
    public bool Scubajoe1 = true;
    public bool Scubajoe2 = false;

    public bool Center = false;
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
    public AudioSource ScubajoeArrival;
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
            if (AiLevel > Rand) {
                if (Scubajoe1 && !Done)
                {
                    Scubajoe1 = false;
                    Scubajoe2 = true;
                    Done = true;
                    StaticOn();
                    Invoke("StaticOff", 0.7f);
                }
                if (Scubajoe2 && !Done)
                {
                    Scubajoe2 = false;
                    Center = true;
                    Done = true;
                    StaticOn();
                    Invoke("StaticOff", 0.7f);
                    StaticOn2();
                    Invoke("StaticOff2", 0.7f);
                }
                if (Center && !Done)
                {
                    StaticOn2();
                    Invoke("StaticOff2", 0.7f);
                    Center = false;
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
            ScubajoeArrival.Play();
            Invoke("JumpscareCheck", TimeBeforejumpScare);
        }

        //////////////
        //nevertouch//
        //////////////
        
        AiLevel = GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ScubaJoeAILevel;
        if (Scubajoe1) {
            ScubaJoeState1.SetActive(true);
            ScubaJoeState2.SetActive(false);
            ScubaJoeState3.SetActive(false);
            CenterState1.SetActive(true);
            CenterState2.SetActive(false);
        }
        if (Scubajoe2)
        {
            ScubaJoeState1.SetActive(false);
            ScubaJoeState2.SetActive(true);
            ScubaJoeState3.SetActive(false);
            CenterState1.SetActive(true);
            CenterState2.SetActive(false);
        }
        if (Center)
        {
            ScubaJoeState1.SetActive(false);
            ScubaJoeState2.SetActive(false);
            ScubaJoeState3.SetActive(true);
            CenterState1.SetActive(false);
            CenterState2.SetActive(true);
        }
        if (Ending)
        {
            ScubaJoeState1.SetActive(false);
            ScubaJoeState2.SetActive(false);
            ScubaJoeState3.SetActive(true);
            CenterState1.SetActive(true);
            CenterState2.SetActive(false);
        }
    }

    public void JumpscareCheck()
    {
        if (!GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().FrontalDoorClosed)
        {
            //Jumpscare
            Debug.Log("You Died from Scuba joe");
            Ending = false;
            Scubajoe1 = true;
            scubaJumpscare.Play();
            GameObject.FindWithTag("MainCamera").GetComponent<CameraLook>().Cameralocked = true;
            if (GameObject.FindWithTag("GameManager").GetComponent<GameManager>().CameraOpen) {
                GameObject.FindWithTag("GameManager").GetComponent<GameManager>().OpenCamera();
            }

            scubaJumpscareAnim.SetActive(true);
            ScubajoeArrival.Stop();
            Invoke("Deathscreen", 0.7f);

            Done2 = false;
        }
        else
        {
            Ending = false;
            Scubajoe1 = true;
            ScubajoeArrival.Stop();
            Done2 = false;
        }
    }

    public void Deathscreen() {
        SceneManager.LoadScene(2);
    }

    //Statics for cam movements do not touch
    public void StaticOn() {
        FullStatic.SetActive(true);
    }
    public void StaticOff() {
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
