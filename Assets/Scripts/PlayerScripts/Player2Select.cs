using UnityEngine;

public class Player2Select : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = transform.position;
        if (Input.GetKeyDown(KeyCode.UpArrow) && playerPos.y != 3)
        {
            playerPos.y += 2;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && playerPos.x != 3.5)
        {
            playerPos.x -= 2;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && playerPos.x != 7.5)
        {
            playerPos.x += 2;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && playerPos.y != -3)
        {
            playerPos.y -= 2;
        }
        transform.position = playerPos;
    }
}
