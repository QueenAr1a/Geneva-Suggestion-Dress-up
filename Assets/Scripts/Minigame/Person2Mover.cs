using UnityEngine;

public class Person2Mover : MonoBehaviour
{
    private float P2speed = 2.5f; // Speed at which the person moves
    private Vector2 person2Position; // Current position of the person

    [SerializeField] GameObject SnowBall;
    [SerializeField] Transform SnowBallSpawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        person2Position = transform.position;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            person2Position.y += P2speed * Time.deltaTime; // Move up
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            person2Position.y -= P2speed * Time.deltaTime; // Move down
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            person2Position.x -= P2speed * Time.deltaTime; // Move left
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            person2Position.x += P2speed * Time.deltaTime; // Move right
        }
        transform.position = person2Position; // Update the position of the person

        ShootSnowball(); // Check for input to shoot a snowball
    }

    void ShootSnowball()
    {


        if (Input.GetKeyDown(KeyCode.RightControl))
        {

            Instantiate(SnowBall, SnowBallSpawner.position, Quaternion.identity); // Spawn a snowball at the specified position
        }
    }
} 
    

