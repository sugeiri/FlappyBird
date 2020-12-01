using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    public float z = 0;
    public float forwardSpeed = 1f;
    void Start()
    {

    }

    void Update()
    {
        z += Time.deltaTime * forwardSpeed; // move towards the player
        if (z > 360.0f)
        {
            z = 0.0f;

        }
        transform.localRotation = Quaternion.Euler(0, 0, z);
    }
}

