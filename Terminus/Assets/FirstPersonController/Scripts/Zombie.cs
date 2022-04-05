using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{

    NavMeshAgent agent;
    public GameObject target;
    public float detectionRange;
    public float hitRange;

    public int currentHealth;
    public int damageAmount;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
   

    void Update()
    {

        if (Vector3.Distance(transform.position, target.transform.position) < detectionRange)
        {
            agent.SetDestination(target.transform.position);    
            if ((Vector3.Distance(transform.position, target.transform.position) < hitRange))
            {

                currentHealth -= damageAmount;
            }
        }

    }
}
