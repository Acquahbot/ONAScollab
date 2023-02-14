using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerManager : MonoBehaviour
{
    public int Power = 100;
    public float FrequencyPower = 10f;
    public float PermanentFreq = 10f;   
    public TMP_Text PowerText;
    public float Timer;
    public float TimeInto = 0f;

    public void Update()
    {
        
        
        Timer += Time.deltaTime;
        if (Timer > FrequencyPower + TimeInto){
            Power = Power - 1;
            TimeInto = Timer;
        }
        FrequencyPower = PermanentFreq -3* GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().NumberOfClosedDoors;
        PowerText.text = "POWER: " + Power.ToString();



        //TEXT COLOR

        if (GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().NumberOfClosedDoors == 0)
        {
            PowerText.color = Color.white;
        }
        else if (GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().NumberOfClosedDoors == 1)
        {
            PowerText.color = Color.yellow;
        }
        else if (GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().NumberOfClosedDoors == 2)
        {
            PowerText.color = new Color(255, 113, 4, 255);
        }
        else if (GameObject.FindWithTag("DoorManager").GetComponent<DoorManager>().NumberOfClosedDoors == 3)
        {
            PowerText.color = Color.red;
        }


    }
}
