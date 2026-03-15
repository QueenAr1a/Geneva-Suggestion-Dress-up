using TMPro;
using UnityEngine;

public class MiniGameScore2 : MonoBehaviour
{
    public TextMeshProUGUI miniGameScore;
    float addUp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float score = Beachball2.score; 

        miniGameScore.text = score.ToString();
    }
}
