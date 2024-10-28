using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   public float speed = 2.0f;  // Speed of the movement
    public float maxOffset = 1.0f;  // Maximum distance from the starting position

    private Vector3 startPos;
    private bool movingRight = true;

    void Start()
    {
        // Save the initial position as the starting point
        startPos = transform.position;
    }

    void Update()
    {
        // Calculate the new position based on direction
        float offset = movingRight ? speed * Time.deltaTime : -speed * Time.deltaTime;
        transform.position += new Vector3(offset, 0, 0);

        // Check if the object has moved too far from the starting point
        if (Vector3.Distance(startPos, transform.position) > maxOffset)
        {
            // Reverse direction if max offset is reached
            movingRight = !movingRight;
        }
    }
}
