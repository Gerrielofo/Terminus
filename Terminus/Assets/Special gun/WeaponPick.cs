using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPick : MonoBehaviour
{
    public Transform equipPosition;
    public float distance = 10f;
    public Camera fpsCam;

    public GameObject rifleOne;
    public GameObject rifleTwo;
    public GameObject rifleThree;

    bool canGrab;
    public void Start()
    {
        rifleOne.SetActive(false);
        rifleTwo.SetActive(false);
        rifleThree.SetActive(false);
    }

    void Update()
    {
    
    }


}
