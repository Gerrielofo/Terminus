using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaController : MonoBehaviour
{
    public float Stamina;
    float maxStamina;

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
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.W)))
            DecreaseEnergy();
        else if (Stamina <= maxStamina)
            IncreaseEnergy();

        StaminaBar.value = Stamina;
    }

    public void DecreaseEnergy()
    {
        if (Stamina != 0)
            Stamina -= staminaDrain * Time.deltaTime;       
    }

    public void IncreaseEnergy()
    {
            Stamina += staminaGain * Time.deltaTime;
    }
}
