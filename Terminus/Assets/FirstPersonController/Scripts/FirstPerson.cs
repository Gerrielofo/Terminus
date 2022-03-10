using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    public Transform view;
    private Vector3 v;
    public float horizontal;
    public float vertical;
    public float speed = 100f;

    private Vector3 bodyRotation;
    private Vector3 cameraRotation;
    public float mousex;
    public float mousey;
    public float mouseSensitivity = 100f;
    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        Movement();
        Mouselook();

    }
    void Movement()
    {
        horizontal = Input.GetAxis("Horizontal");
        v.x = horizontal;
        vertical = Input.GetAxis("Vertical");
        v.z = vertical;
        transform.Translate(v * speed * Time.deltaTime);
    }
    void Mouselook()
    {

        mousey = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        cameraRotation.x = mousey;
        mousex = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        bodyRotation.y = mousex;

        xRotation -= mousex;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.Rotate(bodyRotation);
        view.Rotate(-cameraRotation);


    }
}
