using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Meu_UI : MonoBehaviour
{
    public GameObject PnlWin;
    public GameObject PnlGameOver;
    public TMP_Text txtScore;
    public TMP_Text txtVida;
    public int vida = 3;
    public int score = 0;

    public void Start()
    {
        txtScore.text = "0";
        txtVida.text = "3";
    }

    public void SetScore(int value)
    {
        score += value;
        txtScore.text = score.ToString();

        CheckForWin();
    }

    public void SetVida(int value)
    {
        vida -= value;
        txtVida.text = vida.ToString();
    }

    public void GameOver()
    {
        PnlGameOver.SetActive(true);
    }

    public void Win()
    {
        PnlWin.SetActive(true);
    }

    void CheckForWin()
    {
        if (score >= 5)
        {
            Win();
        }
    }
}
