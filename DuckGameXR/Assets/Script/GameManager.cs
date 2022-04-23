using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float massOfBall;

    [SerializeField] private float timer = 30;
    [SerializeField] private bool gameOver;
    [SerializeField] private int eggsCollected;

    // Start is called before the first frame update
    void Start()
    {
        eggsCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //timer decreases
        timer -= Time.deltaTime;

        //if time gets to 0, game over
        if (timer <= 0)
        {
            Time.timeScale = 0;
            gameOver = true;
        }
    }

    void GameOver()
    {
        //lerp in you lose
        //try again button
        //insert UI elements
        throw new NotImplementedException();
    }

    public void EggCollected()
    {
        eggsCollected++;

        //mass+= whatever mass
        //increase friction

        throw new NotImplementedException();
    }

}
