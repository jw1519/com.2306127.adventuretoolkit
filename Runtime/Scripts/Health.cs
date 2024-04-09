using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int CurruntHealth;
    public TextMeshProUGUI HealthText;
    public Button LoseHealthButton;
    public Button GainHealthbutton;
    void Awake()
    {
        CurruntHealth = 10;
        HealthText.SetText($"Health- {CurruntHealth}");
    }
    public void LoseHealth()
    {
        if (CurruntHealth != 0)
        {
            CurruntHealth--;
            HealthText.SetText($"Health- {CurruntHealth}");
        }
    }
    public void GainHealth()
    {
        if (CurruntHealth != 10)
        {
            CurruntHealth++;
            HealthText.SetText($"Health- {CurruntHealth}");
        }
    }
}
