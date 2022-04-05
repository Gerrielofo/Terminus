using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{ 
    public RaycastHit hit;
    public Camera fpsCam;
    public float range = 100f;
    // Start is called before the first frame update
    void Awake()
    {
        range = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            if (hit.transform.tag == "IsDoor")
            {
                if (hit.transform.gameObject.GetComponent<OnDoor>().isOpen == false)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        hit.transform.gameObject.GetComponent<OnDoor>().wantOpen = true;
                    }
                }
                if (hit.transform.gameObject.GetComponent<OnDoor>().isOpen == true)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        hit.transform.gameObject.GetComponent<OnDoor>().wantClose = true;
                    }
                }
            }
        }
    }

    void OnGUI()
    {
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            if (hit.transform.tag == "IsDoor")
            {
                if (hit.transform.gameObject.GetComponent<OnDoor>().isOpen == false)
                {
                
                    GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 400, 150, 30), "Press 'E' to open");
                }
            }
            if (hit.transform.tag == "IsDoor")
            {
                if (hit.transform.gameObject.GetComponent<OnDoor>().isOpen == true)
                {
                
                    GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 400, 150, 30), "Press 'E' to close");
                }
            }
        }
    }
}
