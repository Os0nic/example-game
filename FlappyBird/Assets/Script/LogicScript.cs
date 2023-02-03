using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    [SerializeField] private int playerScore;
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        // playerScore += scoreToAdd;
        // if (scoreText != null)
        // {
        //     scoreText.text = "ОЧКОВ: " + playerScore.ToString();
        // }
        // else
        // {
        //     Debug.LogError("scoreText is not assigned in the inspector.");
        // }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //метод включит отображение кнопки геймовер
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}


