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
}
