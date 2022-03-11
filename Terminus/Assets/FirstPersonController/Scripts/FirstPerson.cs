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

    public float movement;
    public float walkSpeed = 4f;
    public float sprintSpeed = 8f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    private void Update()
    {
        Movement();
        Mouselook();
        Sprint();

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
        //
        // xRotation pakt de inverted waarde van mousey
        xRotation -= mousey;
        //xRotation clamped van -90 tot 90
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //hier word een vector 3 aangemaakt met de xyz van EulerAngles van view
        Vector3 newRot = view.eulerAngles;
        // hier pakt hij de x as van de v3 newRot zodat hij aangepast kan worden naar xRotation
        newRot.x = xRotation;

        // hier zet hij de resterende assen naar hun originele staat want
        // normaal kan je niet 1 as aanpassen van een eulerAngles
        view.eulerAngles = newRot;


        transform.Rotate(bodyRotation);

    }

    void Sprint()
    {
        transform.Translate(movement * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movement * Input.GetAxis("Vertical") * Time.deltaTime);

<<<<<<< Updated upstream
       
        if (Input.GetKey(KeyCode.LeftShift))
=======
>>>>>>> Stashed changes

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            movement = sprintSpeed;
        }
        else
        {
            movement = walkSpeed;
        }

    }

}
