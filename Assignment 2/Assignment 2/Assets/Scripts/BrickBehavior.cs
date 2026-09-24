using UnityEngine;

public class BrickBehavior : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
    }
}
