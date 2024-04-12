using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Animal : MonoBehaviour
{
    public BoxCollider2D girdArea;

    [SerializeField] TextMeshProUGUI animalCountUI;
    public int animalCount;
    public int animalLimit;
    //public int animalIndex;

    private GameManager gm;
    //private ZooManager zm;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
        //zm = FindObjectOfType<ZooManager>();
        RandomizePosition();
    }

    private void RandomizePosition()
    {
        Bounds bounds = this.girdArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        if (animalCount < animalLimit)
        {
            this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
        }
        else
        {
            this.transform.position = new Vector3(100f, 100f);
            gm.animalsRescued++;
            //zm.AnimalUnlocked(animalIndex);
            //unlock in zoo and remove from level
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.CompareTag("Player"))
        {
            animalCount++;
            RandomizePosition();
        }
    }

    private void OnGUI()
    {
        animalCountUI.text = animalCount.ToString();
    }
}
