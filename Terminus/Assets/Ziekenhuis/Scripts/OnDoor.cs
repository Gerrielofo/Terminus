using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDoor : MonoBehaviour
{
    public float rotDis;
    public float rotDis2;
    public bool isOpen;
    public bool wantOpen;
    public bool wantClose;
    public float rotationSpeed;

    void Start()
    {
       
    }

    void FixedUpdate()
    {
        if(wantOpen == true)
        {
            transform.Rotate(0, rotDis, 0);
            isOpen = true;
            wantOpen = false;
        }
        if(wantClose == true)
        {
            transform.Rotate(0, rotDis2, 0);
            isOpen = false;
            wantClose = false;
        }
        
    }
}