using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    public float rotationSpeed;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Space.Self  --->>> IN RELATION TO ITSELF
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime,0, Space.Self);
    }
    


    /*
    private float rotationTime = 2f; // Time in seconds to complete one rotation
    private float rotationTimer = 0f; // Timer to keep track of time elapsed
    private int currentRotationIndex = 0; // Index of current rotation in rotations array
    private Vector3[] rotations = new Vector3[] { new Vector3(360, 0, 0), new Vector3(0, 360, 0), new Vector3(0, 0, 360) }; // Array of rotations in XYZ order

    void Update()
    {
        rotationTimer += Time.deltaTime;

        // Check if it's time to start a new rotation
        if (rotationTimer >= rotationTime)
        {
            // Reset timer
            rotationTimer = 0f;

            // Increment rotation index
            currentRotationIndex++;
            if (currentRotationIndex >= rotations.Length)
            {
                currentRotationIndex = 0;
            }
        }

        // Get the current rotation from the array
        Vector3 currentRotation = rotations[currentRotationIndex];

        // Rotate the object
        transform.rotation = Quaternion.Euler(currentRotation * (rotationTimer / rotationTime));
    }
    */
}
