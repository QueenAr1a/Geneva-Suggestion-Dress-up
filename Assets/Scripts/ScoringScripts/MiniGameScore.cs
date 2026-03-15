using TMPro;
using UnityEngine;

public class MiniGameScore : MonoBehaviour
{

    public TextMeshProUGUI miniGameScore;
    float addUp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float score = BeachBall.score;

        miniGameScore.text = score.ToString();
    }

}
