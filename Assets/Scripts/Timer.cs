using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public Slider slide; 
    public TextMeshProUGUI timerTime;
    private Scene scene; 
    private float t;
    public AudioSource timer;
    bool startTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        t = 60;
        slide.maxValue = 60;
        slide.value = 60; 
        slide.minValue = 0; 
        scene = SceneManager.GetActiveScene();
        startTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        t -= 1 * Time.deltaTime;
        slide.value = t; 
        timerTime.text = t.ToString("0.00");
        if(t <= 5 && startTimer == true )
        {
            PlayTimer();
        }

        if(t <= 0.1f)
        {
            if(scene.name == "Minigame2")
            {
                SceneManager.LoadScene("Score");
            }

            else
            {
                SceneManager.LoadScene("Minigame2");
            }
               
        }
    }

    void PlayTimer()
    {
        timer.PlayOneShot(timer.clip, 1f);
        startTimer = false;
    }
}
