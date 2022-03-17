using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private Animator anim;
    
    public RaycastHit hit;
    public Camera fpsCam;
    public float range = 100f;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
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
                    OpenDoor();
                }
            }
        }
       
    }
    void OpenDoor()
    {
        
        {
            anim.SetTrigger("Open");
        }
    }
    void OnGUI()
    {
       // GUI.enabled = true;
        //Camera cam = Camera.current;
        //Vector3 pos = cam.WorldToScreenPoint(new Vector3(0, 5, 0));
       // GUI.Label(new Rect(pos.x, Screen.height - pos.y, 150, 130), "Press 'E' to open");
    }
}
