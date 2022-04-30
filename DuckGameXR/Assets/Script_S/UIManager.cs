using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private GameObject timerText;
    private TextMeshProUGUI timerTextT;
    [SerializeField] private TextMeshProUGUI eggCountText;

    // Start is called before the first frame update
    void Start()
    {
        timerTextT = timerText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseEggCountText(int num)
    {
        eggCountText.text = "You have " + num + "eggs.";
    }

    public void changeTimer(float current)
    {
        timerTextT.text = current + " seconds left";
    }
    
    public void GameOverPanel(bool win)
    {
        timerText.SetActive(false);
        gameOverPanel.SetActive(true);
        switch (win)
        {
            case true:
                gameOverText.text="You win! :)";
                break;
            case false:
                gameOverText.text = "You lose! :(";
                break;
        }
    }
}
