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

<<<<<<< Updated upstream
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;
=======
    private Vector3 bodyRotation;
    private Vector3 cameraRotation;
    public float mousex;
    public float mousey;
    public float mouseSensitivity = 100f;
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;

        playerBody.Rotate(Vector3.up * mouseX);
=======
        mousey = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        cameraRotation.x = mousey;
        mousex = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        bodyRotation.y = mousex;


        transform.Rotate(bodyRotation);
        view.Rotate(-cameraRotation);

>>>>>>> Stashed changes
    }
}
