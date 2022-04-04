using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public ParticleSystem burning;
    public ParticleSystem electrifying;



    public void Start()
    {
      
    }
    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Destroy(gameObject);
            
        }
 
    }
    public void ZombieBurning()
    {
        burning.Play(true);
    }
    public void ZombieElectryfing()
    {
        electrifying.Play(true);
    }

}
