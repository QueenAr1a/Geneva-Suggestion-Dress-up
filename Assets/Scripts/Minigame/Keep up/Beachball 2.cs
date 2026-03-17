using UnityEngine;
using TMPro;
public class Beachball2 : MonoBehaviour
{
    public float MinY = -5.5f;

    public float MaxV = 15f;

    Rigidbody2D RB;

    public static float score = 0;
    float multiplier = 1f; 
    public TextMeshProUGUI ScoreTextP2;

    Vector2 SpawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        Screen.SetResolution(1920, 1080, true);

        SpawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < MinY)
        {
            multiplier = 1f; 
            transform.position = SpawnPoint;
            RB.linearVelocity = Vector3.zero;
            TelemetryLogger.Log(this, "Player 2 Ball Fall");
        }

        if (RB.linearVelocity.magnitude > MaxV)
        {
            RB.linearVelocity = Vector3.ClampMagnitude(RB.linearVelocity, MaxV);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddlep2"))
        {
            score += 100 * multiplier;
            multiplier += 0.25f;
            ScoreTextP2.text = score.ToString("00000");
        }
    }
}
