using UnityEngine;

public class BowMovement : MonoBehaviour
{
    public float amplitude = 0.5f; // Magnitude of the movement
    public static float speed = 1.0f; // Speed of the movement

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position; // Get the initial position of the bow
    }

    void Update()
    {
        // Calculate the vertical movement using sine function
        float yOffset = Mathf.Sin(Time.time * speed) * amplitude;

        // Update the position of the bow
        transform.position = startPos + new Vector3(0, yOffset, 0);
    }
}

