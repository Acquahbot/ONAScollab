using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathscreenAutorestart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("RestartGame", 10f);
    }

    // Update is called once per frame
    void RestartGame() {
        SceneManager.LoadScene(1);
    }
}
