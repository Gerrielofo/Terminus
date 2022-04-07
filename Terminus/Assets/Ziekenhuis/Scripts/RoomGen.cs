using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI.Navigation;

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
        toSpawn = Random.Range(0, rooms.Length);
        GameObject newRoom = Instantiate(rooms[toSpawn], start.position, Quaternion.identity);
        newRoom.GetComponent<NavMeshbuild>().Init();
     }
}
