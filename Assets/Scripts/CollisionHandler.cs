using UnityEngine;
using TMPro;
using StarterAssets; // Ensures we can access the FirstPersonController

public class CollisionHandler : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    private bool isDead = false;

    private void Awake()
    {
        // This resets the "switch" in the TouchColumn script to false 
        // every time the scene starts, ensuring the game isn't stuck 
        // in a "Game Over" state from a previous round.
        TouchColumn.isGameOver = false;
    }

    private void Start()
    {
        // Hide the Game Over text when the game starts
        if (gameOverText != null)
            gameOverText.gameObject.SetActive(false);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // Check if the object we hit has the "Obstacle" tag
        if (hit.gameObject.CompareTag("Obstacle") && !isDead)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        isDead = true;

        // 1. Tell all squares to stop moving (The "Master Switch")
        TouchColumn.isGameOver = true;

        // 2. Show the Game Over UI
        if (gameOverText != null)
            gameOverText.gameObject.SetActive(true);

        // 3. Disable the player movement script to "freeze" the player
        GetComponent<FirstPersonController>().enabled = false;
        
        Debug.Log("Game Over!");
    }
}