using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathscreenAutorestart : MonoBehaviour
{
    public Animator Fadeout;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("RestartGame", 10f);
    }

    // Update is called once per frame
    void RestartGame() {
        Fadeout.SetTrigger("FadeOut");
    }
}
