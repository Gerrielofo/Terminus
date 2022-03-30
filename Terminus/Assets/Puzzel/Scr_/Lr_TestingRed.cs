using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lr_TestingRed : MonoBehaviour
{
    [SerializeField]
    private Transform[] points;

    [SerializeField]
    private Lr_LineController line;

    private void Start()
    {
        line.SetUpLine(points);
    }


}
