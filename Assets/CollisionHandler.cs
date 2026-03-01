using UnityEngine;
using TMPro;
using StarterAssets; // This line tells your script to look inside the StarterAssets namespace

public class CollisionHandler : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    private bool isDead = false;

    private void Start()
    {
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

        // 1. Show the UI
        if (gameOverText != null)
            gameOverText.gameObject.SetActive(true);

        // 2. Disable the FirstPersonController script
        // Because of the namespace, we can access it directly like this:
        GetComponent<FirstPersonController>().enabled = false;
        
        Debug.Log("Game Over!");
    }
}