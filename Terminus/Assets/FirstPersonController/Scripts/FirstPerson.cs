using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    public Vector3 v;
    public float horizontal;
    public float vertical;
    public float speed = 100f;

    void Start()
    {

    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        v.x = horizontal;
        vertical = Input.GetAxis("Vertical");
        v.z = vertical;
        transform.Translate(v * speed * Time.deltaTime);
    }
}
