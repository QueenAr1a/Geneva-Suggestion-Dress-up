using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class DressScore : MonoBehaviour
{
    float addUp;
    public TextMeshProUGUI dressupScore;
    
    void Start()
    {
        Screen.SetResolution(1920, 1080, true);

        float hatScore = Player1Select.hatFinalPoints; //Change this to grab the new clothing value off of the clothing piece - each piece does stage calculation seperately 
        float shirtScore = Player1Select.shirtFinalPoints;
        float pantsScore = Player1Select.pantsFinalPoints;
        float shoesScore = Player1Select.shoesFinalPoints;

        addUp = hatScore + (shirtScore + pantsScore + shoesScore);
        //addUp *= 10; 
        dressupScore.text = addUp.ToString();
        TelemetryLogger.Log(this, "Player 1 Dress Score", dressupScore);
    }
}
