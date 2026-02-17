using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public Slider slide; 
    public TextMeshProUGUI timerTime;
    private float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        t = 60;
        slide.maxValue = 60;
        slide.value = 60; 
        slide.minValue = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        t -= 1 * Time.deltaTime;
        slide.value = t; 
        timerTime.text = t.ToString("0.00");

        if(t <= 0.1f)
        {
            SceneManager.LoadScene("Score");
        }
    }
}
