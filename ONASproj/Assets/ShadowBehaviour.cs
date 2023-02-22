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
    }
    public void UnlockDoors() {
        GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().LockDoorsChange();
        redLights.SetActive(false);
        Done = false;
    }

    public void CheckShadowProb() {
        int Rand = Random.Range(1, 20);
        if (AiLevel > Rand + 10)
        {
            ShadowJoeAppereance.SetActive(true);
            ShadowActive = true;
        }
        
    }


}
