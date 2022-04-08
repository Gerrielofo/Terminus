using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerDeur : MonoBehaviour
{
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
        transform.Rotate(0, 90, 0);
        openLocker = false;
    }
    
}
