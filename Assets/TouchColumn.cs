using UnityEngine;

public class TouchColumn : MonoBehaviour
{
    // This is the global switch for all squares
    public static bool isGameOver = false; 

    public Transform top;
    public Transform bottom;
    public float speed = 5f;
    public float gap = 3f;
    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
        top.position += Vector3.up * gap / 2;
        bottom.position += Vector3.down * gap / 2;
    }

    private void Update()
    {
        // Only move if the game is NOT over
        if (!isGameOver)
        {
            transform.position += speed * Time.deltaTime * Vector3.left;
        }

        if (transform.position.x < leftEdge) {
            Destroy(gameObject);
        }
    }
}
    