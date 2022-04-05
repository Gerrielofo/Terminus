using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaController : MonoBehaviour
{
    public float Stamina;
    public float maxStamina;

    public Slider StaminaBar;
    public float staminaDrain;
    public float staminaGain;

    void Start()
    {
        maxStamina = Stamina;
        StaminaBar.maxValue = maxStamina;

    }

    private void Update()
    {
        StaminaBar.value = Stamina;

        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.W)))
            DecreaseEnergy();
        else if (Stamina <= maxStamina)
            IncreaseEnergy();

    }

    public void DecreaseEnergy()
    {
        if (Stamina <= 0)
            Stamina -= staminaDrain * Time.deltaTime;       
    }

    public void IncreaseEnergy()
    {
            Stamina += staminaGain * Time.deltaTime;
    }
}
