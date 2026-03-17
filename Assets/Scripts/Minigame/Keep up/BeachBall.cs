using UnityEngine;
using TMPro;

public class BeachBall : MonoBehaviour
{
    public float MinY = -5.5f;

    public float MaxV = 15f;

    Rigidbody2D RB;

    public static float score = 0;

    float multiplier = 1f; 
    public TextMeshProUGUI ScoreTextP1;

    Vector2 SpawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();   
        
        SpawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.y < MinY)
        {
            multiplier = 1f; 
            transform.position = SpawnPoint;
            RB.linearVelocity = Vector3.zero;
            TelemetryLogger.Log(this, "Player 1 Ball Fall");
        }

        if (RB.linearVelocity.magnitude  > MaxV)
        {
            RB.linearVelocity = Vector3.ClampMagnitude(RB.linearVelocity, MaxV);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddlep1"))
        {
            score += 100 * multiplier;
            multiplier += 0.25f;
            ScoreTextP1.text = score.ToString("00000");
        }
    }
}
