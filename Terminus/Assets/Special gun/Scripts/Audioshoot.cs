using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioshoot : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            source.Play();
        }
        if (Input.GetButtonUp("Fire1"))
        {
            source.Stop();
        }



    }
}
