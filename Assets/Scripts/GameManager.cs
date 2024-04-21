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

    private AudioManager audioManager;

    private void Awake()
    {
        audioManager = FindObjectOfType<AudioManager>();        
    }

    public void WinCheck()
    {
        animalsRescued++;
        if(animalsRescued == maxAnimals)
        {
            GameWin();
        }
    }

    public void GameWin()
    {
        Time.timeScale = 0f;
        gameWinMenu.SetActive(true);
    }

    public void PlayAgain()
    {
        audioManager.PlaySFX(audioManager.buttonClick);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HomeButton()
    {
        audioManager.PlaySFX(audioManager.buttonClick);
        Destroy(audioManager.gameObject);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Zoo");
    }
}
