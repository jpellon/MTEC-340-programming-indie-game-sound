using UnityEngine;

public class PaddleBehavior : MonoBehaviour
{
    public float Speed = 5.0f;

    public KeyCode LeftDirection = KeyCode.LeftArrow;
    public KeyCode RightDirection = KeyCode.RightArrow;

    void Start()
    {
        
    }

    void Update()
    {
        float movement = 0.0f;

        if(Input.GetKey(RightDirection))
        {
            movement += Speed;
        }

        if(Input.GetKey(LeftDirection))
        {
            movement -= Speed;
        }

        movement *= Time.deltaTime;

        transform.Translate(movement, 0.0f, 0.0f);

        if(transform.position.x < -6.5f)
        {
            transform.position = new Vector3(-6.5f, transform.position.y, transform.position.z);
        }

        if(transform.position.x > 6.5f)
        {
            transform.position = new Vector3(6.5f, transform.position.y, transform.position.z);
        }
    }
}