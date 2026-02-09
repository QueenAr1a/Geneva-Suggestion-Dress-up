using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using Unity.VisualScripting;

public class DressScore2 : MonoBehaviour
{
    public TextMeshProUGUI dressupScore;
    float addUp; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float hatScore = Player1Select.shoesChoice;
        float shirtScore = Player1Select.hatChoice;
        float pantsScore = Player1Select.shirtChoice;
        float shoesScore = Player1Select.pantsChoice;



        addUp = hatScore + (shirtScore + pantsScore + shoesScore);
        addUp *= 10; 
        dressupScore.text = addUp.ToString();
    }


}
