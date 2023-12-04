using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text txtScore;
    int score = 0;
    private void Start()
    {
        txtScore.text = "0";
    }

    // Update is called once per frame
    public void SetScore()
    {
        score += 1;
    }
}
