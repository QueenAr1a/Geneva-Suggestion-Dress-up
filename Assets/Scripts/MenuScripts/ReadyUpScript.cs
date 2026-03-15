using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadyUpScript : MonoBehaviour
{
    [Header("Ready Buttons")]
    public SpriteRenderer player1Ready;
    public SpriteRenderer player2Ready;
    public Sprite player1Gray;
    public Sprite player1Green;
    public Sprite player2Gray;
    public Sprite player2Green;

    [Header("Tutorial")]
    public GameObject tutorialPanel;

    [Header("Scene")]
    public float startDelay = 3f;

    bool p1Ready = false;
    bool p2Ready = false;
    bool tutorialOpen = false;
    bool locked = false;

    void Start()
    {
        player1Ready.sprite = player1Gray;
        player2Ready.sprite = player2Gray;
        tutorialPanel.SetActive(false);
    }

    void Update()
    {
        if (locked) return;

        if (Input.GetKeyDown(KeyCode.T))
        {
            tutorialOpen = !tutorialOpen;
            tutorialPanel.SetActive(tutorialOpen);
            return;
        }

        if (tutorialOpen) return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            p1Ready = !p1Ready;
            player1Ready.sprite = p1Ready ? player1Green : player1Gray;
        }

        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            p2Ready = !p2Ready;
            player2Ready.sprite = p2Ready ? player2Green : player2Gray;
        }

        if (p1Ready && p2Ready)
        {
            locked = true;
            StartCoroutine(StartGame());
        }
    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(startDelay);
        SceneManager.LoadScene("MainGame");
    }
}