using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int key;
    int score;
    public float time;
    public static GameManager instance;
    public Text scoreText;
    public Text timeText;
    public Text keyText;

    private void Awake()
    {
        instance = this;
        key = 0;
    }

    public void incrementScore()
    {
        score++;
        scoreText.text = "Score: "+score.ToString()+"/6";
    }
    public void incrementKey()
    {
        key++;
        keyText.text = "Keys: " + key.ToString() + "/3";
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeText.text = "Time Left: " + (int)time;
        if(time <= 0)
        {
            print("You lose");
        }
        if(score == 6)
        {
            print("You win");
        }
        if (key == 3)
        {
            print("you have won the Game");
        }
        
    }
}
