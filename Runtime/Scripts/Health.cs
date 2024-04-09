using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private int curruntHealth;
    public TextMeshProUGUI HealthText;
    public Button LoseHealthButton;
    void Start()
    {
        curruntHealth = 10;
        HealthText.SetText($"Health- {curruntHealth}");
    }

    public void LoseHealth()
    {
        curruntHealth--;
        HealthText.SetText($"Health- {curruntHealth}");
    }
    private void Update()
    {
        if (curruntHealth == 0)
        {
            curruntHealth = 0;
            LoseHealthButton.enabled = false;
        }
    }
}
