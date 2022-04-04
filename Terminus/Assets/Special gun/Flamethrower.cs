using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flamethrower : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float sphereRadius = 1f;

    private float nextTimeToFire = 0f;
    public float fireRate = 10f;


    public Camera fpsCam;
    public ParticleSystem particleShoot;



    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Spit();
            Flame();
    
        }
    }
    void Spit()
    {
        RaycastHit hit;
        if (Physics.SphereCast(fpsCam.transform.position, sphereRadius, fpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
                target.ZombieBurning();

            }
        }


    }
    void Flame()
    {
        particleShoot.Play();
        Debug.Log(transform.name);
    }


}