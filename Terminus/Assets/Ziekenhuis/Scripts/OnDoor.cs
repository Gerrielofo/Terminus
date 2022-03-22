using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDoor : MonoBehaviour
{
    public bool isOpen = false;
    public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    public void DoTheOpen()
    {
        anim.Play("Heehee");
    }
}
