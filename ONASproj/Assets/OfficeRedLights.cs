using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeRedLights : MonoBehaviour
{   
    public Light _Light;
    public float timer;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        alarmLight();
    }

    void alarmLight(){
        if(timer > 0) timer =- Time.deltaTime;
        if(timer<=0) _Light.enabled = !_Light.enabled;
    }
}
