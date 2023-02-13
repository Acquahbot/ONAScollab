using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float MaxRotation = 200f;
    public float MinRotation = 160f;
    public float RotationSpeed = 1.5f;
    public float MouseX;

    private void Start()
    {
        
    }

    void Update()
    {
        Debug.Log(transform.rotation.y);
        int edgeScrollSize = 80;

        if (Input.mousePosition.x < edgeScrollSize && transform.eulerAngles.y > MinRotation)
        {
            transform.Rotate(0f, -1 * RotationSpeed * Time.deltaTime, 0f);
        }
        if (Input.mousePosition.x > Screen.width - edgeScrollSize && transform.eulerAngles.y < MaxRotation) {
            transform.Rotate(0f, 1 * RotationSpeed * Time.deltaTime, 0f);
        }
       
    }
}
