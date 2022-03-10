using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    public Vector3 v;
    public float horizontal;
    public float vertical;
    public float speed = 100f;

    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        v.x = horizontal;
        vertical = Input.GetAxis("Vertical");
        v.z = vertical;
        transform.Translate(v * speed * Time.deltaTime);
    }
    void Mouselook()
    {

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
