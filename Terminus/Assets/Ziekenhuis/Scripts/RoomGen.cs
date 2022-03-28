using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGen : MonoBehaviour
{
    public GameObject[] rooms;
    public Transform start;
    public int toSpawn;
    public int spawnAmount;
    public bool canSpawn;
    // Start is called before the first frame update
    void Start()
    {
        spawnAmount = Random.Range(0, 100);
        if (spawnAmount <= 95)
        {
            toSpawn = Random.Range(0, rooms.Length);
            Instantiate(rooms[toSpawn], start.position, Quaternion.identity);
            spawnAmount += 1;
        }
        else
        {
            canSpawn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
