using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDoor : MonoBehaviour
{
    public float rotAmount;
    public bool isOpen;
    public bool wantOpen;
    public bool wantClose;
    public float rotationSpeed;
    public float rotationSpeed2;

    void Start()
    {
        wantOpen = false;
        wantClose = false;
    }

    void FixedUpdate()
    {
        if(wantOpen == true && rotAmount < 90)
        {
            transform.Rotate(0, rotationSpeed, 0);
            rotAmount += 2;
        }
        if(wantClose == true && rotAmount > 0)
        {
            transform.Rotate(0, rotationSpeed2, 0);
            rotAmount -= 2;
            
        }
        if (rotAmount == 90)
        {
            isOpen = true;
            wantOpen = false;
        }
        if (rotAmount == 0)
        {
            isOpen = false;
            wantClose = false;
        }
    }
}