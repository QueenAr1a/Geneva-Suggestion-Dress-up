using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;


public class AudienceScoreRandom : MonoBehaviour
{
    public TextMeshProUGUI audienceScore;
    private int scoreRandom; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreRandom = Random.Range(1, 100);
        audienceScore.text = scoreRandom.ToString();
        Screen.SetResolution(1920, 1080, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
