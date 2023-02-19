using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeepTrackFill : MonoBehaviour
{
    public TMP_Text thisSlider;
    public float TemporaryFillRef;
    void Update()
    {
        thisSlider = this.GetComponent<TMP_Text>();
        TemporaryFillRef = GameObject.FindWithTag("TemporaryManager").GetComponent<TemporaryBehaviour>().TemporaryFill;
        thisSlider.text = TemporaryFillRef.ToString() + "%";
        //thisSlider.value = GameObject.FindWithTag("TemporaryManager").GetComponent<TemporaryBehaviour>().TemporaryFill;
    }
}
