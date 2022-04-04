using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electronew : MonoBehaviour
{
    public float damage = 10f;
    public float range = 15f;
    public GameObject area;


    public float fireRate = 10f;
    private float nextTimeToFire = 0f;



    public Camera fpsCam;
    public ParticleSystem particleShoot;
    public ParticleSystem particleShootTwo;
    public ParticleSystem particleShootThree;


    void Start()
    {
        area.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Plasma();
            Bliksem();

        }
        if (Input.GetButtonUp("Fire1"))
        {
            area.SetActive(false);
        }
    }
    
    void Plasma()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
     
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                area.SetActive(true);
                target.TakeDamage(damage);
                target.ZombieElectryfing();
            }

        }


    }
    void Bliksem()
    {
        particleShoot.Play();
        particleShootTwo.Play();
        particleShootThree.Play();
    
    }

   


}