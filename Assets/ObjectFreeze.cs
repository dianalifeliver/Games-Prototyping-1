using UnityEngine;
using StarterAssets;

public class ObjectFreeze : MonoBehaviour
{
    public GameObject text;

    private FirstPersonController fpsController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (text != null)
            {
                text.SetActive(true);
            }

            fpsController = other.GetComponent<FirstPersonController>();
            if (fpsController != null)
            {
                fpsController.enabled = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (text != null)
            {
                text.SetActive(false);
            }

            if (fpsController != null)
            {
                fpsController.enabled = true;
            }
        }
    }
}