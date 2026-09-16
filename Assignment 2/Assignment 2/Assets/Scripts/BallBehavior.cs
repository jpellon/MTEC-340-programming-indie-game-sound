using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float Speed = 5.0f;

    public float xDirection;
    public float yDirection;

    void Start()
    {
        // Random starting position
        transform.position = new Vector3(
            Random.Range(-6.0f, 6.0f),
            transform.position.y,
            transform.position.z
        );

        // Random starting direction
        xDirection = Random.Range(0, 2);

        if(xDirection == 0)
        {
            xDirection = -1;
        }

        yDirection = Random.Range(0, 2);

        if(yDirection == 0)
        {
            yDirection = -1;
        }
    }

    void Update()
    {
        float velocityX = Speed * xDirection;
        float velocityY = Speed * yDirection;

        float movementX = velocityX * Time.deltaTime;
        float movementY = velocityY * Time.deltaTime;

        transform.Translate(movementX, movementY, 0.0f);

        if(transform.position.x > 7.0f)
        {
            xDirection *= -1;

            transform.position = new Vector3(
                7.0f,
                transform.position.y,
                transform.position.z
            );
        }

        if(transform.position.x < -7.0f)
        {
            xDirection *= -1;

            transform.position = new Vector3(
                -7.0f,
                transform.position.y,
                transform.position.z
            );
        }

        if(transform.position.y > 4.0f)
        {
            yDirection *= -1;

            transform.position = new Vector3(
                transform.position.x,
                4.0f,
                transform.position.z
            );
        }
    }
}