using UnityEngine;
using TMPro;
public class Beachball2 : MonoBehaviour
{
    public float MinY = -5.5f;

    public float MaxV = 15f;

    Rigidbody2D RB;

    int Score = 0;
    public TextMeshProUGUI ScoreTextP2;

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

        if (transform.position.y < MinY)
        {
            transform.position = SpawnPoint;
            RB.linearVelocity = Vector3.zero;
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
            Score += 100;
            ScoreTextP2.text = Score.ToString("00000");
        }
    }
}
