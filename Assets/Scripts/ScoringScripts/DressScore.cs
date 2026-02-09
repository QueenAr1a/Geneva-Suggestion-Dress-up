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
        float hatScore = Player1Select.shoesChoice;
        float shirtScore = Player1Select.hatChoice;
        float pantsScore = Player1Select.shirtChoice;
        float shoesScore = Player1Select.pantsChoice;

        addUp = hatScore + (shirtScore + pantsScore + shoesScore); 
        dressupScore.text = addUp.ToString();
    }
}
