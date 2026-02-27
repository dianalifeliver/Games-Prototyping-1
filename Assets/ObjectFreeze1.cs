using UnityEngine;
using StarterAssets;

public class ObjectFreeze1 : MonoBehaviour
{
    public GameObject text;
    public float maxSurfaceDistance = 0f;  // Changed to 0f → triggers only on real overlap

    private FirstPersonController fpsController;
    private bool gameOverTriggered = false;
    private Collider myCollider;

    void Start()
    {
        myCollider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !gameOverTriggered)
        {
            // Log bounds for debug (optional – you can remove later)
            Debug.Log($"Trigger Bounds: Center={myCollider.bounds.center}, Size={myCollider.bounds.size}");

            // With 0f → only triggers on actual collider overlap
            Vector3 playerCenter = other.bounds.center;
            Vector3 closestOnSurface = myCollider.ClosestPoint(playerCenter);
            float distToSurface = Vector3.Distance(playerCenter, closestOnSurface);

            if (distToSurface > maxSurfaceDistance)
            {
                Debug.Log($"Ignored: Too far from surface ({distToSurface:F2}m)");
                return;
            }

            gameOverTriggered = true;

            if (text != null) text.SetActive(true);

            fpsController = other.GetComponent<FirstPersonController>();
            if (fpsController != null) fpsController.enabled = false;
        }
    }

    // Draws red wireframe bounds in Scene view (helps visualize trigger zone)
    private void OnDrawGizmos()
    {
        if (myCollider != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(myCollider.bounds.center, myCollider.bounds.size);
        }
    }
}