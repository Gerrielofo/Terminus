
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPickPuzzle : MonoBehaviour
{
    float pickPosition;
    public float PickPosition
    {
        get { return pickPosition; }
        set
        {
            pickPosition = value;
            pickPosition = Mathf.Clamp(pickPosition, 0f, 1f);
        }
    }

    [SerializeField] float pickSpeed = 3f;



    float cyllinderPosition;
    public float CyllinderPosition
    {
        get { return cyllinderPosition; }
        set
        {
            cyllinderPosition = value;
            cyllinderPosition = Mathf.Clamp(cyllinderPosition, 0f, 1f);
        }
    }

    [SerializeField] float cyllinderRotationSpeed = 0.4f;
    [SerializeField] float cyllinderRetentionSpeed = 0.2f;


    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Pick();
        Cyllinder();
        UpdateAnimator();
    }

    void Cyllinder()
    {
        CyllinderPosition -= cyllinderRetentionSpeed * Time.deltaTime;
        CyllinderPosition += Mathf.Abs(Input.GetAxisRaw("Vertical")) * Time.deltaTime * cyllinderRotationSpeed;
    }

    private void Pick()
    {
        PickPosition += Input.GetAxisRaw("Horizontal") * Time.deltaTime * pickSpeed;
    }

    private void UpdateAnimator()
    {
        animator.SetFloat("PickPosition", PickPosition);
        animator.SetFloat("LockOpen", CyllinderPosition);
    }



}
