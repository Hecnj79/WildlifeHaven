using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ZooManager : MonoBehaviour
{
    public void PlayFarm()
    {
        SceneManager.LoadScene("Farm");
    }

    public void PlayCity()
    {
        SceneManager.LoadScene("City");
    }

    public void PlayArctic()
    {
        SceneManager.LoadScene("Arctic");
    }

    public void PlayJungle()
    {
        SceneManager.LoadScene("Jungle");
    }

    public void PlaySavanna()
    {
        SceneManager.LoadScene("Savanna");
    }

    public void PlayForest()
    {
        SceneManager.LoadScene("Forest");
    }
}
