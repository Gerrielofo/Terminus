using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerDeur : MonoBehaviour
{
    public float rotAmount;
    public float rotationSpeed;
    public float rotationSpeed2;
    public bool openLocker = false;

    void Update()
    {
        if(openLocker == true)
        {
            OpenLocker();
        }
    }

    public void OpenLocker()
    {

    }
    
}
