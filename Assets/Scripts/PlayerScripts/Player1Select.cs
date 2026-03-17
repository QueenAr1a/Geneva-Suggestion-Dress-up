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

    public int player1HatScore;
    public int player1ShirtScore;
    public int player1PantsScore;
    public int player1Shoescore;

    public static int hatFinalPoints;
    public static int shirtFinalPoints;
    public static int pantsFinalPoints;
    public static int shoesFinalPoints;

    GameObject store; 
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
        if (Input.GetKeyDown(KeyCode.W) && cursorOffset.y != playerPos.y && indexTrack >= 5)
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

        GameObject chosenOutfit = player1options[indexTrack];

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            Destroy(store, 0.1f);
            store = Instantiate(chosenOutfit);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            TelemetryLogger.Log(this, "Player 1 Selection");

            var data = new SelectEventData()
            {
                hatSelection = hatChoice.ToString(),
                shirtSelection = shirtChoice.ToString(),
                pantsSelection = pantsChoice.ToString(),
                shoesSelection = shoesChoice.ToString()
            };
            TelemetryLogger.Log(this, "Player 1 SelectionSummary", data);

            if (indexTrack > -1 && indexTrack < 5)
            {
                hatChoice = indexTrack;
                //Debug.Log(hatChoice);

                //find the clothingPoints on the InstanceStageBonus and bring it here
                InstanceStageBonus pointTotal = player1options[indexTrack].GetComponent<InstanceStageBonus>();
                hatFinalPoints = pointTotal.clothingPoints; 
                Debug.Log(hatFinalPoints);
            }

            else if (indexTrack > 4 && indexTrack < 9)
            {
                shirtChoice = indexTrack;
                Debug.Log(shirtChoice);


                //find the clothingPoints on the InstanceStageBonus and bring it here
                InstanceStageBonus pointTotal = player1options[indexTrack].GetComponent<InstanceStageBonus>();
                shirtFinalPoints = pointTotal.clothingPoints;
            }

            else if (indexTrack > 8 && indexTrack < 13)
            {
                pantsChoice = indexTrack;
                Debug.Log(pantsChoice);


                //find the clothingPoints on the InstanceStageBonus and bring it here
                InstanceStageBonus pointTotal = player1options[indexTrack].GetComponent<InstanceStageBonus>();
                pantsFinalPoints = pointTotal.clothingPoints;
            }

            else if (indexTrack > 12 && indexTrack < 17)
            {
                shoesChoice = indexTrack;
                Debug.Log(shoesChoice);


                //find the clothingPoints on the InstanceStageBonus and bring it here
                InstanceStageBonus pointTotal = player1options[indexTrack].GetComponent<InstanceStageBonus>();
                shoesFinalPoints = pointTotal.clothingPoints;
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
    }
    
}
