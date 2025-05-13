using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [Header("UI Elements")]
    public Slider healthSlider;
    public Canvas healthCanvas; // Canvas to make health bar visible in-game
    public Transform target; // Reference to the target (e.g., player or enemy)
    public Vector3 offset = new Vector3(0, 2, 0); // Offset to position above character

    private void Start()
    {
        if (healthCanvas != null)
        {
            healthCanvas.worldCamera = Camera.main; // Ensure it faces the camera
        }
    }

    private void Update()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
            transform.LookAt(Camera.main.transform);
            transform.Rotate(0, 180, 0); // Correct rotation so text is readable
        }
    }

    public void SetMaxHealth(float maxHealth)
    {
        if (healthSlider != null)
        {
            healthSlider.maxValue = maxHealth;
            healthSlider.value = maxHealth;
        }
    }

    public void UpdateHealth(float currentHealth)
    {
        if (healthSlider != null)
        {
            healthSlider.value = currentHealth;
        }
    }
}


