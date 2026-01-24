using UnityEngine;

public class Player1Select : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = transform.position; 
        if (Input.GetKeyDown(KeyCode.W) && playerPos.y != 3)
        {
            playerPos.y += 2; 
        }

        if (Input.GetKeyDown(KeyCode.A) && playerPos.x != -7.5)
        {
            playerPos.x -= 2;
        }

        if (Input.GetKeyDown(KeyCode.D) && playerPos.x != -3.5)
        {
            playerPos.x += 2;
        }

        if (Input.GetKeyDown(KeyCode.S) && playerPos.y != -3)
        {
            playerPos.y -= 2;
        }
        transform.position = playerPos; 
    }
}
