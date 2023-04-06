using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f; // speed of player movement
    public float leftBound = -7.0f; // left boundary of player movement
    public float rightBound = 7.0f; // right boundary of player movement
    public float bottomBound = -3.8f; // bottom boundary of player movement

    // Update is called once per frame
    void Update()
    {
        // get input from horizontal axis (left and right arrow keys)
        float horizontalInput = Input.GetAxis("Horizontal");

        // move player left or right based on input
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // restrict player movement to left and right boundaries
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, leftBound, rightBound);

        // clamp player y position to bottom boundary
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, bottomBound, Mathf.Infinity);

        transform.position = clampedPosition;
    }
}
