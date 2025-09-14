// 11/9/2568 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed = 5f; // Movement speed

    void Update()
    {
        // Initialize movement vector
        Vector3 movement = Vector3.zero;

        // Check for WASD key inputs and update movement vector
        if (Input.GetKey(KeyCode.W)) // Forward
        {
            movement += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S)) // Backward
        {
            movement += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A)) // Left
        {
            movement += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D)) // Right
        {
            movement += Vector3.right;
        }

        // Normalize movement vector to ensure consistent speed in all directions
        if (movement.magnitude > 1)
        {
            movement.Normalize();
        }

        // Move the character
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}