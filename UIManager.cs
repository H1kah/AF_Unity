using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject pnlGameOver;
    public TMP_Text txtScore;
    public TMP_Text txtLives;
    public GameObject player;

    int score = 0;
    int lives = 3;

    private void Start()
    {
        txtScore.text = "0";
        txtLives.text = "3";
    }

    public void SetScore()
    {
        score += 1;
        txtScore.text = score.ToString();
    }

    public void SetLives()
    {
        lives -= 1;
        txtLives.text = lives.ToString();

        if (lives <= 0)
        {
            Destroy(player);
            GameOver();
        }
    }

    void GameOver()
    {
        pnlGameOver.SetActive(true);
    }
}