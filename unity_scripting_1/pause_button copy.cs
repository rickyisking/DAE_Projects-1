using UnityEngine;
using UnityEngine.UI; // Import for UI components like Button
using TMPro; // Import for TextMeshPro support

public class pause_button : MonoBehaviour
{
    private TMP_Text buttonText; // Text component (TextMeshPro)
    private bool isPaused = false; // Toggle state
    // Assign Player in Inspector
    public GameObject player;
    Movement player_script;

    private Rigidbody2D rb;

    void Start()
    {
        // Automatically find the TextMeshPro text component inside the button
        buttonText = GetComponentInChildren<TMP_Text>(); 

        // Add a listener to the button click event
        GetComponent<Button>().onClick.AddListener(TogglePlayPause);
        player_script = player.GetComponent<Movement>();

        // Cache the player's Rigidbody2D for easy access
        //rb = player.GetComponent<Rigidbody2D>();
    }

    void TogglePlayPause()
    {
        isPaused = !isPaused; // Toggle state

        if (isPaused)
        {
            buttonText.text = "Play"; // Change button text
            player_script.SetFrozen(true);
        }
        else
        {
            buttonText.text = "Pause"; // Change button text back
            player_script.SetFrozen(false);
        }
    }

    
}