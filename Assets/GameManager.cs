using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject gameWinMenu;

    public int animalsRescued;
    public int maxAnimals;

    private void Update()
    {
        if (animalsRescued == maxAnimals) GameWin();
    }

    public void GameWin()
    {
        Time.timeScale = 0f;
        gameWinMenu.SetActive(true);
    }

    public void PlayAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HomeButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Zoo");
    }
}
