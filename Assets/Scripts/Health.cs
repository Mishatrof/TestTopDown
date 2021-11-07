using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour, IHealth
{

    public float CurrentHealth;
    public Slider HealthSlider;

    private void Start()
    {
        HealthSlider.maxValue = CurrentHealth;
        HealthSlider.value = CurrentHealth;
        HealthSlider.gameObject.SetActive(false);
    }
    public void TakeDmg(float dmg)
    {
        CurrentHealth -= dmg;
        HealthSlider.value = CurrentHealth;
        HealthSlider.gameObject.SetActive(true);
        if (CurrentHealth < 0)
        {
            Destroy(gameObject);
        }
    }
}
