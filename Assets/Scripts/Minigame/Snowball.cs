using UnityEngine;

public class Snowball : MonoBehaviour
{
    private float SnowballSpeed = 5f; // Speed at which the snowball moves
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * SnowballSpeed * Time.deltaTime; // Move the snowball to the right
        if(transform.position.x > 10f || transform.position.x < -10f || transform.position.y > 10f || transform.position.y < -10f) // If the snowball goes off-screen, destroy it
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Person1") || collision.gameObject.CompareTag("Person2")) // If the snowball collides with a person, destroy it
        {
            Destroy(gameObject);
        }

        if(collision.gameObject.CompareTag("Cover")) // If the snowball collides with a wall, destroy it
        {
            
            Destroy(gameObject);
        }
    }
}
