using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowBehaviour : MonoBehaviour
{
    public int AiLevel;
    public float Timer;
    public float downTime = 10f;
    public bool ShadowActive;
    public bool Done = false;
    public AudioSource labAlarm;
    public GameObject ShadowJoeAppereance;
    public GameObject redLights;
    public void Start()
    {
        AiLevel = GameObject.FindWithTag("GameManager").GetComponent<GameManager>().ShadowAILevel;
    }
    public void Update()
    {
        if (ShadowActive) {
            Timer += Time.deltaTime;
        }
        else {
            Timer = 0;
            ShadowJoeAppereance.SetActive(false);   
        }
        if (Timer > 2f && !Done) {
            OpenDoors();
            Done = true;
            Invoke("UnlockDoors", downTime);
            
        }
    }

    public void OpenDoors() {
        GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().OpenDoorsOffice();
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().OpenCamera();
        redLights.SetActive(true);
        labAlarm.Play();
    }
    public void UnlockDoors() {
        GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().LockDoorsChange();
        redLights.SetActive(false);
        labAlarm.Stop();
        Done = false;
    }

    public void CheckShadowProb() {
        int Rand = Random.Range(1, 20);
        if (AiLevel > 10)
        {
            Rand = Rand + 6;
        }
        else if (AiLevel > 5) {
            Rand = Rand + 2;
        }
        if (AiLevel > Rand)
        {
            ShadowJoeAppereance.SetActive(true);
            ShadowActive = true;
        }
        
    }


}
