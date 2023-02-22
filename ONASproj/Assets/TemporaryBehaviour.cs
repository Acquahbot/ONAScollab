using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

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
    public bool Done = false;

    //Stuff for jumpscare
    public GameObject PermStatic;
    public GameObject JumpscarePref;
    public AudioSource vdmJumpscareAudioOpendoor;
    public AudioSource vdmJumpscareAudioCloseddoor;

    public void Update()
    {

        Timer += Time.deltaTime;
        TimerforRefill += Time.deltaTime;
        if (Timer > TimeTo)
        {
            TemporaryFill-=10f;
            TimeTo = Timer + 21f-GameObject.FindWithTag("GameManager").GetComponent<GameManager>().TemporaryAILevel;
        }

        if (TemporaryFill <= 0f && !Done)
        {
            JumpscareSequence();
            Done = true;
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
        Invoke("Jumpscare", 10f);
    }

    public void Jumpscare() {
        GameObject.FindWithTag("MainCamera").GetComponent<CameraLook>().Cameralocked = true;
        if (GameObject.FindWithTag("GameManager").GetComponent<GameManager>().CameraOpen)
        {
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().OpenCamera();
        }
        JumpscarePref.SetActive(true);
        if (GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().FrontalDoorClosed)
        {
            vdmJumpscareAudioCloseddoor.Play();
        }
        else
        {
            vdmJumpscareAudioOpendoor.Play();
        }
        Invoke("DeathScreen", 0.7f);
    }

    public void DeathScreen() {
        SceneManager.LoadScene(2);
    }

}
