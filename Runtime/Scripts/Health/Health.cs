using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int CurrentHealth;
    public TextMeshProUGUI HealthText;
    public Button LoseHealthButton;
    public Button GainHealthbutton;
    public int StartingHP = 100;
    public int maxHealth = 10;
    void Awake()
    {
        SetCurrentHealth(StartingHP);
    }

    public void SetCurrentHealth(int HealthToSet)
    {
        CurrentHealth = HealthToSet;
        
    }

    public void LoseHealth(int HealthToDecrease)
    {
        if (CurrentHealth > 0)
        {
            CurrentHealth -= HealthToDecrease;
        }
        if (CurrentHealth < 0)
        {
            CurrentHealth = 0;
        }
    }
    public void GainHealth(int HealthToGain)
    {
        if (CurrentHealth < maxHealth)
        {
            CurrentHealth += HealthToGain;
        }
        if (CurrentHealth > maxHealth)
        {
            CurrentHealth = maxHealth;
        }
    }
    private void Update()
    {
        HealthText.SetText($"Health- {CurrentHealth}");
    }
}
