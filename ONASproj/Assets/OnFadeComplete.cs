using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnFadeComplete : MonoBehaviour
{
    public void OnFadeCompleted()
    {
        SceneManager.LoadScene(1);
    }
}
