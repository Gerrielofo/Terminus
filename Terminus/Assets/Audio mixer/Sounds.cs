using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    private static Sounds backGroundSound;

    public void Awake()
    {
        if (backGroundSound == null) 
        {
            backGroundSound = this;
            DontDestroyOnLoad(backGroundSound);
        }

        else
        {
            Destroy(gameObject);
        }
    }

}
