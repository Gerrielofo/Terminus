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
                if (Input.GetKey(KeyCode.E))
                {
                    hit.transform.gameObject.GetComponent<OnDoor>().DoTheOpen();
                }

            }
        }
    }
       
    //    void OnGUI()
    //    {
    //        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
    //        {
    //            if (isOpen == false)
    //            {
    //                if (hit.transform.tag == "IsDoor")
    //                {
    //                    GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 400, 150, 30), "Press 'E' to open the door");
    //                }
    //            }
    //        }
    //    }
}
