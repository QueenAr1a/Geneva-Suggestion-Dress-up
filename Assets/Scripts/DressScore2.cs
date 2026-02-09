using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class DressScore2 : MonoBehaviour
{
    public TextMeshProUGUI dressupScore;
    private int scoreDress;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float hatScore = Player2Select.hatChoice;
        float shirtScore = Player2Select.shirtChoice;
        float pantsScore = Player2Select.pantsChoice;
        float shoesScore = Player2Select.shoesChoice;
        float sum = hatScore + (shirtScore * pantsScore * shoesScore);

        dressupScore.text = sum.ToString();
    }


}
