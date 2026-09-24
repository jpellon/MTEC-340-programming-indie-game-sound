using UnityEngine;

using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float LaunchForce = 5.0f;
    public float SpeedIncrement = 1.05f;
    public float PaddleInfluence = 0.2f;

    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        LaunchBall();
    }

    void LaunchBall()
    {
        Vector2 direction = new Vector2(
            GetNonZeroRandomFloat(),
            GetNonZeroRandomFloat()
        ).normalized;

        _rb.AddForce(direction * LaunchForce, ForceMode2D.Impulse);
    }
float GetNonZeroRandomFloat()
{
    float num;

    do
    {
        num = Random.Range(-1.0f, 1.0f);
    }
    while (Mathf.Approximately(num, 0.0f));

    return num;
}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Paddle"))
        {
            if (!Mathf.Approximately(
                other.rigidbody.linearVelocity.x, 0.0f))
            {
                Vector2 direction =
                    _rb.linearVelocity * (1 - PaddleInfluence)
                    + other.rigidbody.linearVelocity
                    * PaddleInfluence;

                _rb.linearVelocity =
                    _rb.linearVelocity.magnitude
                    * direction.normalized
                    * SpeedIncrement;
            }
        }
    }

}