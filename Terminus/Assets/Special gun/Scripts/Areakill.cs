using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Areakill : MonoBehaviour
{
    public float radius = 10f;
    public float damage = 10f;
    public Camera fpsCam;
    private void FixedUpdate()
    {
        Collider[] colliders = Physics.OverlapSphere(fpsCam.transform.position, radius);
     foreach(Collider nearbyObject in colliders)
        {
            Target target = nearbyObject.GetComponent<Target>();
            {
                if (target != null)
                {
                    target.TakeDamage(damage);
                    target.ZombieElectryfing();
                }
            }

        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(this.transform.position, radius);
    }
}
