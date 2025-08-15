using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowMouse : MonoBehaviour
{

    public float speed = 5.0f; // The speed at which the camera follows the mouse
    private Camera mainCamera; // Reference to the main camera
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main; // Assigning the main camera

    }

    // Update is called once per frame
    void Update()
    {

        FollowMouse();
    }

    private void FollowMouse()
    {
        Vector3 mousePosition = Input.mousePosition; // Get the mouse position
        mousePosition.z = mainCamera.nearClipPlane; // Set the distance from camera
        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(mousePosition); // Convert to world position
        worldPosition.z = transform.position.z; // Keep the current Z position of the camera
        transform.position = Vector3.Lerp(transform.position, worldPosition, speed * Time.deltaTime); // Smoothly move to the mouse position

    }
}
