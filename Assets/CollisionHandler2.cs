using UnityEngine;
using TMPro;
using StarterAssets; 

public class CollisionHandler2 : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    private bool isDead = false;

    private void Awake()
    {
        // Reset the "Game Over" master switch
        TouchColumn.isGameOver = false;
    }

    private void Start()
    {
        // Hide the Game Over text when the game starts
        if (gameOverText != null)
            gameOverText.gameObject.SetActive(false);
    }

    // Using OnTriggerEnter ensures detection works even if the player is standing still
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object we touched has the "Obstacle" tag
        if (other.CompareTag("Obstacle") && !isDead)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        isDead = true;

        // Tell all squares to stop moving
        TouchColumn.isGameOver = true;

        // Show the Game Over UI
        if (gameOverText != null)
            gameOverText.gameObject.SetActive(true);

        // Disable player movement
        GetComponent<FirstPersonController>().enabled = false;
        
        Debug.Log("Game Over!");
    }
}