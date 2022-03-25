using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDoor : MonoBehaviour
{
    private float x;
    private float z;
    public bool isOpen;
    public bool wantOpen;
    private float rotationSpeed;

    void Start()
    {
        x = 0.0f;
        z = 0.0f;
        isOpen = true;
        rotationSpeed = 75.0f;
    }

    void FixedUpdate()
    {
        if (isOpen == true)
        {
            x += Time.deltaTime * rotationSpeed;

            if (x > 360.0f)
            {
                x = 0.0f;
                isOpen = false;
            }
        }
        else
        {
            z += Time.deltaTime * rotationSpeed;

            if (z > 90.0f)
            {
                z = 0.0f;
                isOpen = true;
            }
        }

        transform.localRotation = Quaternion.Euler(x, 0, z);
    }
}