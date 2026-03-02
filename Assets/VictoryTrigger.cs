using UnityEngine;
using StarterAssets; // Required to find the FirstPersonController script

public class VictoryTrigger : MonoBehaviour
{
    public GameObject victoryText; // Drag your Victory UI object here

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger is the Player
        // Note: Make sure your PlayerCapsule has the "Player" tag!
        if (other.CompareTag("Player"))
        {
            // 1. Show the Victory UI
            if (victoryText != null)
                victoryText.SetActive(true);
            
            // 2. Stop the columns from moving (using your master switch)
            TouchColumn.isGameOver = true; 
            
            // 3. Freeze the player movement
            // This finds the FirstPersonController script on the player and turns it off
            other.GetComponent<FirstPersonController>().enabled = false;
            
            Debug.Log("Victory!");
        }
    }
}