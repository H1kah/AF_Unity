using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Aula_23_10
{
    public class GameManager : MonoBehaviour
    {
        public int score = 0;

        private void Start()
        {
            score = PlayerPrefs.GetInt("Score");
            print("Score Inicial: " + score);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                PlayerPrefs.SetInt("Score", score);
                SceneManager.LoadScene("Fase1");   
            } 
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                PlayerPrefs.SetInt("Score", score);
                SceneManager.LoadScene("Fase2");
            }
            else if (Input.GetKeyDown(KeyCode.P))
            {
                AddScore(10);
                print(score);
            }
        }

        void AddScore(int value)
        {
            score += value;
        }

        private void OnApplicationQuit()
        {
            PlayerPrefs.DeleteKey("Score");
        }
    }
}
