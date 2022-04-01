using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 mOffset;

    private float mZCoord;

    public bool movable;

    private void Start()
    {
        movable = true;
    }

    void OnMouseDown()
    {
        if (movable == true)
        {
            mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

            mOffset = gameObject.transform.position - GetMouseWorldPos();
        }
        
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {   
        transform.position = GetMouseWorldPos() + mOffset;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Hit Marker")
        {
            movable = false;
        }
       
    }



}
