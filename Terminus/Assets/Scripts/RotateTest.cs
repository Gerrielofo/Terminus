using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour
{
    public Vector3 rot;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(rot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
