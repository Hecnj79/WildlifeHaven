using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZooManager : MonoBehaviour
{
    public Image[] animal;

    public void AnimalUnlocked(int index)
    {
        animal[index].enabled = true;
    }
}
