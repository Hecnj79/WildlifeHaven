using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ZooManager : MonoBehaviour
{
    public GameObject winButton;

    private AudioManager audioManager;

    private void Start()
    {
        if (CollectManager.instance.allAnimalsRescued == true)
        {
            winButton.gameObject.SetActive(true);
        }
    }

    private void Awake()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    public void PlayFarm()
    {
        audioManager.PlaySFX(audioManager.buttonClick);
        Destroy(audioManager.gameObject);
        SceneManager.LoadScene("Farm");
    }

    public void PlayCity()
    {
        audioManager.PlaySFX(audioManager.buttonClick);
        Destroy(audioManager.gameObject);
        SceneManager.LoadScene("City");
    }

    public void PlayArctic()
    {
        audioManager.PlaySFX(audioManager.buttonClick);
        Destroy(audioManager.gameObject);
        SceneManager.LoadScene("Arctic");
    }

    public void PlayJungle()
    {
        audioManager.PlaySFX(audioManager.buttonClick);
        Destroy(audioManager.gameObject);
        SceneManager.LoadScene("Jungle");
    }

    public void PlaySavanna()
    {
        audioManager.PlaySFX(audioManager.buttonClick);
        Destroy(audioManager.gameObject);
        SceneManager.LoadScene("Savanna");
    }

    public void PlayForest()
    {
        audioManager.PlaySFX(audioManager.buttonClick);
        Destroy(audioManager.gameObject);
        SceneManager.LoadScene("Forest");
    }

    public void GameWinButton()
    {
        audioManager.PlaySFX(audioManager.buttonClick);
        Destroy(audioManager.gameObject);
        SceneManager.LoadScene("EndGame");
    }
}
