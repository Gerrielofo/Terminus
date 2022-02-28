
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
            cyllinderPosition = Mathf.Clamp(cyllinderPosition, 0f, MaxRotationDistance);
        }
    }

    [SerializeField] float cyllinderRotationSpeed = 0.4f;
    [SerializeField] float cyllinderRetentionSpeed = 0.2f;


    Animator animator;
   
    bool paused = false;

    float targetPosition;
    
    [SerializeField] float leanency = 0.1f;
   
    float MaxRotationDistance
    {
        get
        {
            return 1f - Mathf.Abs(targetPosition - PickPosition) + leanency;
        }
    }

    bool shaking;
    float tension = 0f;
    [SerializeField] float tensionMultiplicator = 1f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        Init();
    }

    void Init()
    {
        Reset();

        targetPosition = UnityEngine.Random.value;
    }

    public void Reset()
    {
        CyllinderPosition = 0f;
        PickPosition = 0f;
        tension = 0f;
        paused = false;

    }

    private void Update()
    {
        if(paused==true) { return; }
        if (Input.GetAxisRaw("Vertical") == 0)
        {
            Pick();
        }
        Shaking();
        Cyllinder();
        UpdateAnimator();
    }

    void Shaking()
    {
        shaking = MaxRotationDistance - CyllinderPosition < 0.03f;
        if (shaking)
        {
            tension += Time.deltaTime * tensionMultiplicator;
            if(tension > 1f)
            {
                PickBreak();
            }
        }
    }

    void PickBreak()
    {
        Debug.Log("You broke the pick");
        Reset();
        
    }

    void Cyllinder()
    {
        CyllinderPosition -= cyllinderRetentionSpeed * Time.deltaTime;
        CyllinderPosition += Mathf.Abs(Input.GetAxisRaw("Vertical")) * Time.deltaTime * cyllinderRotationSpeed;
        if (CyllinderPosition > 0.98f)
        {
            Win();
        }
        
    }

    void Win()
    {
        paused = true;
        Debug.Log("You opened the lock");
    }

    private void Pick()
    {
        PickPosition += Input.GetAxisRaw("Horizontal") * Time.deltaTime * pickSpeed;
    }

    private void UpdateAnimator()
    {
        animator.SetFloat("PickPosition", PickPosition);
        animator.SetFloat("LockOpen", CyllinderPosition);
        animator.SetBool("Shake", shaking);
    }



}
