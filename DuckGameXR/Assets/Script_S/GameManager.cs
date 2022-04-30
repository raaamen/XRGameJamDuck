using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float massOfBall;

    [SerializeField] private float timer = 30;
    [SerializeField] private bool gameOver;
    [SerializeField] private bool gameWin;
    public int eggsCollected;
    [SerializeField] private UIManager uiManage;

    // Start is called before the first frame update
    void Start()
    {
        uiManage = GetComponent<UIManager>();
        eggsCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //timer decreases
        timer -= Time.deltaTime;
        uiManage.changeTimer(timer);
        //if time gets to 0, game over
        if (timer <= 0)
        {
            Time.timeScale = 0;
            GameOver();
        }
    }

    void GameOver()
    {
        gameOver = true;
        uiManage.GameOverPanel(gameWin);
        throw new NotImplementedException();
    }

    public void EggCollected()
    {
        eggsCollected+=1;
        //uiManage.increaseEggCountText(eggsCollected);

        //mass+= whatever mass
        //increase friction
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
