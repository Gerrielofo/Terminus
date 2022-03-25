using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGen : MonoBehaviour
{
    public GameObject[] rooms;
    public Transform start;
    public int toSpawn;
    // Start is called before the first frame update
    void Start()
    {
        toSpawn = Random.Range(0, rooms.Length);
        Instantiate(rooms[toSpawn], start.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
