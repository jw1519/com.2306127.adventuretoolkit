using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int CurrentHealth;
    public TextMeshProUGUI HealthText;
    public Button LoseHealthButton;
    public Button GainHealthbutton;
    public int StartingHP;
    void Awake()
    {
        SetCurrentHealth(StartingHP);
    }

    private void SetCurrentHealth(int HealthToSet)
    {
        CurrentHealth = 10;
        HealthText.SetText($"Health- {CurrentHealth}");
    }

    public void LoseHealth()
    {
        if (CurrentHealth != 0)
        {
            CurrentHealth--;
            HealthText.SetText($"Health- {CurrentHealth}");
        }
    }
    public void GainHealth()
    {
        if (CurrentHealth != 10)
        {
            CurrentHealth++;
            HealthText.SetText($"Health- {CurrentHealth}");
        }
    }
}
