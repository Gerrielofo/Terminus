using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public float fireRate = 10f;
    private float nextTimeToFire = 0f;


    public Camera fpsCam;
    public ParticleSystem ParticleShoot;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
            Muzzle();
            
        }
    
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
                
            }
           
        }


    }
    void Muzzle()
    {
        ParticleShoot.Play();
        Debug.Log(transform.name);
    }


}