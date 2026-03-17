using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PersonMover : MonoBehaviour
{
    private float speed = 2.5f; // Speed at which the person moves
    private Vector2 personPosition; // Current position of the person
    private float Timer = 0f; // Timer to track the time between snowball throws

    [SerializeField] GameObject SnowBall;
    [SerializeField] Transform SnowBallSpawn;
    public TextMeshProUGUI scoreTextP1;
    float multiplier = 1f;
    public float score = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the person to the right
        personPosition = transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            personPosition.y += speed * Time.deltaTime; // Move up
        }
        if (Input.GetKey(KeyCode.S))
        {
            personPosition.y -= speed * Time.deltaTime; // Move down
        }
        if (Input.GetKey(KeyCode.A))
        {
            personPosition.x -= speed * Time.deltaTime; // Move left
        }
        if (Input.GetKey(KeyCode.D))
        {
            personPosition.x += speed * Time.deltaTime; // Move right
        }
        transform.position = personPosition; // Update the position of the person

        Timer += Time.deltaTime; // Increment the timer by the time since the last frame
        if (Timer >= 0.5f) // If the timer has reached 0.5 seconds, allow the player to shoot a snowball
        {
            ShootSnowball(); // Check for input to shoot a snowball
           
        }

       
    }

    void ShootSnowball()
    {


        if (Input.GetKeyDown(KeyCode.E)) 
        { 
        
                Instantiate(SnowBall, SnowBallSpawn.position, Quaternion.identity); // Spawn a snowball at the specified position
            Timer = 0f; // Reset the timer
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Snowball2")) // If the snowball collides with a person, destroy it
        {
            
            score += 100 * multiplier;
            multiplier += 0.25f;
            scoreTextP1.text = score.ToString("00000");
        }
    }
    }
