using UnityEngine;

public class PaddleBehavior : MonoBehaviour
{
    public float Speed = 5.0f;

    public KeyCode LeftDirection = KeyCode.LeftArrow;
    public KeyCode RightDirection = KeyCode.RightArrow;

    private Rigidbody2D rb;
    private float direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction = 0.0f;

        if (Input.GetKey(RightDirection))
        {
            direction += 1.0f;
        }

        if (Input.GetKey(LeftDirection))
        {
            direction -= 1.0f;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocityX = direction * Speed;
    }
}
