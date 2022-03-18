using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private Animator anim;
    
    public RaycastHit hit;
    public Camera fpsCam;
    public float range = 100f;

    public bool isOpen;
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
                if(Input.GetKey(KeyCode.E))
                {
                    if (isOpen == false)
                    {                    
                        Animator anim = gameObject.GetComponent<Animator>();
                        anim.SetFloat("Heehee", -1);
                        anim.Play("DoorAnim", -1, float.NegativeInfinity);
                        anim.Play("Door2Anim", -1, float.NegativeInfinity);
                        isOpen = true;
                    }
                    else
                    {
                        Animator anim = gameObject.GetComponent<Animator>();
                        anim.SetFloat("Heehee", 1);
                        anim.Play("DoorAnim", 1, float.NegativeInfinity);
                        anim.Play("Door2Anim", 1, float.NegativeInfinity);
                        isOpen = false;
                    }
                }
                    
            }
        }
        //if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
           //if (hit.transform.tag == "IsDoor")
            {
                //if (isOpen == true)
                {
                    //if (Input.GetKey(KeyCode.E))
                    {
                        //Animator anim = gameObject.GetComponent<Animator>();
                        //anim.SetFloat("Heehee", 1);
                        //anim.Play("DoorAnim", 1, float.NegativeInfinity);
                        //anim.Play("Door2Anim", 1, float.NegativeInfinity);
                        //isOpen = false;
                    }
                }
                
            }
        }
    }
    void OnGUI()
    {
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            if (isOpen == false)
            {
                if (hit.transform.tag == "IsDoor")
                {
                    GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 400, 150, 30), "Press 'E' to open the door");
                }
            }
        }
    }
}
