using System;
using UnityEngine;

public class Player1Select : MonoBehaviour
{
    public GameObject[] player1options;
    private int indexTrack; 
    public float moveAmount;
    private Vector3 cursorOffset;

    public static int hatChoice;
    public static int shirtChoice;
    public static int pantsChoice;
    public static int shoesChoice;



    GameObject storeHat;
    GameObject storeShirt;
    GameObject storePants;
    GameObject storeShoes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cursorOffset = transform.position;
        indexTrack = 0;
        Screen.SetResolution(1920, 1080, true);
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 playerPos = transform.position; 
        if (Input.GetKeyDown(KeyCode.W) && cursorOffset.y != playerPos.y && indexTrack >= 4)
        {
            playerPos.y += moveAmount;
            indexTrack -= 4; 
        }

        if (Input.GetKeyDown(KeyCode.A) && playerPos.x != cursorOffset.x)
        {
            playerPos.x -= moveAmount;
            indexTrack -= 1; 
        }

        if (Input.GetKeyDown(KeyCode.D) && playerPos.x < cursorOffset.x + (moveAmount * 2.5))
        {
            playerPos.x += moveAmount;
            indexTrack += 1; 
        }

        if (Input.GetKeyDown(KeyCode.S) && playerPos.y > cursorOffset.y - (moveAmount * 2.5))
        {
            playerPos.y -= moveAmount;
            indexTrack += 4; 
        }
        transform.position = playerPos;

        if (indexTrack > -1 && indexTrack < 4)
        {
            GameObject chosenHat = player1options[indexTrack];
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(storeHat, 0.1f);
                storeHat = Instantiate(chosenHat);
            }
        }

        else if (indexTrack > 3 && indexTrack < 8)
        {
            shirtChoice = indexTrack;
           

            GameObject chosenShirt = player1options[indexTrack];
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(storeShirt, 0.1f);
                storeShirt = Instantiate(chosenShirt);
            }
        }

        else if (indexTrack > 7 && indexTrack < 12)
        {
            pantsChoice = indexTrack;
        

            GameObject chosenPants = player1options[indexTrack];
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(storePants, 0.1f);
                storePants = Instantiate(chosenPants);
            }
        }

        else if (indexTrack > 11 && indexTrack < 16)
        {
            shoesChoice = indexTrack;
           

            GameObject chosenShoes = player1options[indexTrack];
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(storeShoes, 0.1f);
                storeShoes = Instantiate(chosenShoes);
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            var data = new SelectEventData()
            {
                hatSelection = hatChoice.ToString(),
                shirtSelection = shirtChoice.ToString(),
                pantsSelection = pantsChoice.ToString(),
                shoesSelection = shoesChoice.ToString(),
                playerTrack = 1
            }; 
            TelemetryLogger.Log(this, "SelectionSummary", data);

            if (indexTrack > -1 && indexTrack < 4)
            {
                hatChoice = indexTrack;
                
            }

            else if (indexTrack > 3 && indexTrack < 8)
            {
                shirtChoice = indexTrack;
                
            }

            else if (indexTrack > 7 && indexTrack < 12)
            {
                pantsChoice = indexTrack;
               
            }

            else if (indexTrack > 11 && indexTrack < 16)
            {
                shoesChoice = indexTrack;
               
            }
        }
    }


    [System.Serializable]
    public struct SelectEventData
    {
        public string hatSelection;

        public string shirtSelection;

        public string pantsSelection;

        public string shoesSelection;

        public int playerTrack; 
    }
    
}
