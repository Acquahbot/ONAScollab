using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepTrackFill : MonoBehaviour
{
    public Slider thisSlider;
    public float TemporaryFillRef;
    void Update()
    {
        thisSlider = this.GetComponent<Slider>();
        TemporaryFillRef = GameObject.FindWithTag("TemporaryManager").GetComponent<TemporaryBehaviour>().TemporaryFill;
        thisSlider.value = TemporaryFillRef;
        //thisSlider.value = GameObject.FindWithTag("TemporaryManager").GetComponent<TemporaryBehaviour>().TemporaryFill;
    }
}
