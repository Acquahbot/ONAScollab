using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HoursText : MonoBehaviour
{
    public TMP_Text hoursText;
    public bool GameWon = false;

    public void Start()
    {
        Invoke("AM1", 120f);
        Invoke("AM2", 240f);
        Invoke("AM3", 360f);
        Invoke("AM4", 480f);
        Invoke("AM5", 600f);
        Invoke("AM6", 720f);
    }




    /// /////// ///
    /// Invokes /// 
    /// /////// ///

    public void AM1() {
        hoursText.text = "1 AM";
    }
    public void AM2()
    {
        hoursText.text = "2 AM";
    }
    public void AM3()
    {
        hoursText.text = "3 AM";
    }
    public void AM4()
    {
        hoursText.text = "4 AM";
    }
    public void AM5()
    {
        hoursText.text = "5 AM";
    }
    public void AM6()
    {
        hoursText.text = "6 AM";
        GameWon = true;
    }


}
