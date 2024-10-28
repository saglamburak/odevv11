using UnityEngine;

public class NewEmptyCSharpScript : MonoBehaviour

{
 public float speed = 1.0f;  // Speed of the movement

    private Vector3 startPos;
    private bool movingRight = true;

    void Start()
    {
        // Save the initial position as the starting point
        startPos = transform.position;
    }

    void Update()
    {
        // Move the object to the right or left based on the direction
        if (movingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            // Reverse direction if the object moves 0.5 units to the right
            if (transform.position.x >= startPos.x + 0.5f)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.position -= Vector3.right * speed * Time.deltaTime;
            // Reverse direction if the object moves 0.5 units to the left
            if (transform.position.x <= startPos.x - 0.5f)
            {
                movingRight = true;
            }
        }
    }
}
