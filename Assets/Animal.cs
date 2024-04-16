using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Animal : MonoBehaviour
{
    public BoxCollider2D gridArea;

    [SerializeField] TextMeshProUGUI animalCountUI;
    public int animalCount;
    public int animalLimit;

    private GameManager gm;    

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
        RandomizePosition();
    }

    private void RandomizePosition()
    {
        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        if (animalCount < animalLimit && !CollectManager.instance.CheckAllCollected(gameObject.name))
        {
            this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
        }
        else
        {
            this.transform.position = new Vector3(100f, 100f);
            gm.animalsRescued++;
            CollectManager.instance.CollectObject(gameObject.name);
            animalCount = animalLimit;
            animalCountUI.text = animalLimit.ToString();
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
