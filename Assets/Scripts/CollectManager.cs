using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectManager : MonoBehaviour
{
    public static CollectManager instance = null; 
    public Dictionary<string, int> collectedObjects = new Dictionary<string, int>(); 
    public Dictionary<string, int> totalObjects = new Dictionary<string, int>(); 
    public Dictionary<string, bool> allCollected = new Dictionary<string, bool>();

    public bool allAnimalsRescued = false;

    private int totalAnimalsRescued = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void CollectObject(string objectName)
    {
        if (!collectedObjects.ContainsKey(objectName))
        {
            collectedObjects[objectName] = 0;
        }
        collectedObjects[objectName]++;

        if (!totalObjects.ContainsKey(objectName))
        {
            totalObjects[objectName] = 0;
            totalAnimalsRescued++;
        }
        if (collectedObjects[objectName] >= totalObjects[objectName])
        {
            allCollected[objectName] = true;

            if(totalAnimalsRescued == 517)
            {
                allAnimalsRescued = true;
            }
            
        }
    }

    public bool CheckAllCollected(string objectName)
    {
        if (!allCollected.ContainsKey(objectName))
        {
            allCollected[objectName] = false;
        }
        return allCollected[objectName];
    }
}
