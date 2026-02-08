using System;
using UnityEngine;

public class Player1Select : MonoBehaviour
{
    public GameObject[] player1options;
    private int indexTrack; 
    public float moveAmount;
    private Vector3 cursorOffset;

    private int hatChoice;
    private int shirtChoice;
    private int pantsChoice;
    private int shoesChoice;

    GameObject store; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cursorOffset = transform.position;
        indexTrack = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = transform.position; 
        if (Input.GetKeyDown(KeyCode.W) && cursorOffset.y != playerPos.y)
        {
            playerPos.y += moveAmount;
            indexTrack -= 4; 
        }

        if (Input.GetKeyDown(KeyCode.A) && playerPos.x != cursorOffset.x)
        {
            playerPos.x -= moveAmount;
            indexTrack -= 1; 
        }

        if (Input.GetKeyDown(KeyCode.D) && playerPos.x != cursorOffset.x + (moveAmount * 3))
        {
            playerPos.x += moveAmount;
            indexTrack += 1; 
        }

        if (Input.GetKeyDown(KeyCode.S) && playerPos.y != cursorOffset.y - (moveAmount * 3))
        {
            playerPos.y -= moveAmount;
            indexTrack += 4; 
        }
        transform.position = playerPos;

        GameObject chosenOutfit = player1options[indexTrack];

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            Destroy(store, 0.1f);
            store = Instantiate(chosenOutfit);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if(indexTrack > -1 && indexTrack < 5)
            {
                hatChoice = indexTrack;
            }

            else if (indexTrack > 4 && indexTrack < 9)
            {
                shirtChoice = indexTrack;
            }

            else if (indexTrack > 8 && indexTrack < 13)
            {
                pantsChoice = indexTrack;
            }

            else if (indexTrack > 12 && indexTrack < 17)
            {
                shoesChoice = indexTrack;
            }
        }
    }

    
}
