using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class PowerManager : MonoBehaviour
{
    public int Power = 100;
    public float FrequencyPower = 10f;
    public float PermanentFreq = 10f;   
    public TMP_Text PowerText;
    public float Timer;
    public float TimeInto = 0f;

    //prefabscanvas
    public GameObject Usage1;
    public GameObject Usage2;
    public GameObject Usage3;
    public GameObject Usage4;

    //Runoutofpower
    public bool RunOut = false;
    public AudioSource RunOutSteps;
    public AudioSource[] Audios;
    public GameObject[] Everything;

    //jumpscare
    public Animator CamShakeAnimator;
    public GameObject analJumpscareAnim;
    public AudioSource analJumpscare;


    public void RunOutSequence() {
        RunOutSteps.Play();
        if (GameObject.FindWithTag("GameManager").GetComponent<GameManager>().CameraOpen)
        {
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().OpenCamera();
        }
        GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().OpenDoorsOffice();

        for (int i = 0; i < Audios.Length; i++)
            {
                Audios[i].Stop();
            }
        for (int i = 0; i < Everything.Length; i++)
        {
            Everything[i].SetActive(false);
        }
        int Rand = Random.Range(10, 20);
        Invoke("JumpscareSequence", Rand);
    }
    public void JumpscareSequence() {
        RunOutSteps.Stop();
        analJumpscare.Play();
        analJumpscareAnim.SetActive(true);
        CamShakeAnimator.SetTrigger("Shake");
        Invoke("Deathscreen", 0.7f);
    }
    public void Deathscreen()
    {
        SceneManager.LoadScene(1);
    }

    public void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > FrequencyPower + TimeInto){
            Power = Power - 1;
            TimeInto = Timer;
        }
        if (GameObject.FindWithTag("DoorManager") == null)
        {

        }
        else {
            FrequencyPower = PermanentFreq - 2.3f * GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().NumberOfClosedDoors;
        }
        PowerText.text = "POWER: " + Power.ToString();

        if (Power <= 0) {
            Power = 0;
        }
        if (Power == 0 && !RunOut) {
            RunOutSequence();
            RunOut = true;
        }


        //TEXT COLOR
        if (GameObject.FindWithTag("DoorManager") == null) {
            Usage1.SetActive(false);
            Usage2.SetActive(false);
            Usage3.SetActive(false);
            Usage4.SetActive(false);
        }
        else if (GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().NumberOfClosedDoors == 0)
        {
            Usage1.SetActive(false);
            Usage2.SetActive(false);
            Usage3.SetActive(false);
            Usage4.SetActive(false);
        }
        else if (GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().NumberOfClosedDoors == 1)
        {
            Usage1.SetActive(true);
            Usage2.SetActive(false);
            Usage3.SetActive(false);
            Usage4.SetActive(false);
        }
        else if (GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().NumberOfClosedDoors == 2)
        {
            Usage1.SetActive(true);
            Usage2.SetActive(true);
            Usage3.SetActive(false);
            Usage4.SetActive(false);
        }
        else if (GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().NumberOfClosedDoors == 3)
        {
            Usage1.SetActive(true);
            Usage2.SetActive(true);
            Usage3.SetActive(true);
            Usage4.SetActive(false);
        }
        else if (GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().NumberOfClosedDoors == 4)
        {
            Usage1.SetActive(true);
            Usage2.SetActive(true);
            Usage3.SetActive(true);
            Usage4.SetActive(true);
        }


    }
}
