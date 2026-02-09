using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class DressScore : MonoBehaviour
{
    public TextMeshProUGUI dressupScore;
    private int scoreDress;
    
    void Start()
    {
        float hatScore = Player1Select.hatChoice;
        float shirtScore = Player1Select.shirtChoice;
        float pantsScore = Player1Select.pantsChoice;
        float shoesScore = Player1Select.shoesChoice;
        float sum = hatScore + (shirtScore * pantsScore * shoesScore);

        dressupScore.text = sum.ToString();
    }
}
