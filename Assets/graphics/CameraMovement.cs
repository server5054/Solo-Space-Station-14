using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 10f;

    void Update()
    {
        // Get input for WASD/Arrow keys
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float vertical = Input.GetAxis("Vertical");     // W/S or Up/Down

        // Calculate movement direction relative to frame rate
        Vector3 movement = new Vector3(horizontal, vertical, 0);
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}