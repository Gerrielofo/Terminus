using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Sway : MonoBehaviour
{
    public float intensity;
    public float smooth;

    private Quaternion originRotation;
    // Start is called before the first frame update
    void Start()
    {
        originRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSway();
    }

    void UpdateSway()
    {
        //Controls
        float t_x_mouse = Input.GetAxis("Mouse X");
        float t_y_mouse = Input.GetAxis("Mouse Y");

        //Calculate target rotation
        Quaternion t_x_adj = Quaternion.AngleAxis(-intensity * t_x_mouse, Vector3.up);
        Quaternion t_y_adj = Quaternion.AngleAxis(-intensity * t_y_mouse, Vector3.right);
        Quaternion target_rotation = originRotation * t_x_adj * t_y_adj;

        //rotate Towards target rotation
        transform.localRotation = Quaternion.Lerp(transform.localRotation, target_rotation, Time.deltaTime * smooth);
    }
}
