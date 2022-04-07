using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI.Navigation;
using UnityEngine.AI;

public class NavMeshbuild : MonoBehaviour
{

    public NavMeshAgent[] agents;

    // Start is called before the first frame update
    public void Init()
    {
        GetComponent<NavMeshSurface>().BuildNavMesh();
        for (int i = 0; i < agents.Length; i++)
        {
            agents[i].enabled = true;
        }
    }

}
