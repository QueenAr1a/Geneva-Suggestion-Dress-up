using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerTime;
    private float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        t = 60; 
    }

    // Update is called once per frame
    void Update()
    {
        t -= 1 * Time.deltaTime; 
        timerTime.text = t.ToString("0.00");

        if(t <= 0.1f)
        {
            SceneManager.LoadScene("Score");
        }
    }
}
