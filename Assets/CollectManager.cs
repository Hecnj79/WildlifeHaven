using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectManager : MonoBehaviour
{
    public static CollectManager instance = null; // Static instance of GameManager which allows it to be accessed by any other script.
    public Dictionary<string, int> collectedObjects = new Dictionary<string, int>(); // Dictionary to keep track of collected objects
    public Dictionary<string, int> totalObjects = new Dictionary<string, int>(); // Dictionary to keep track of total objects
    public Dictionary<string, bool> allCollected = new Dictionary<string, bool>(); // Dictionary to keep track of whether all objects of a certain type have been collected

    // Awake is always called before any Start functions
    void Awake()
    {
        // Check if instance already exists
        if (instance == null)
        {
            // If not, set instance to this
            instance = this;
        }
        // If instance already exists and it's not this:
        else if (instance != this)
        {
            // Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
        }

        // Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }

    public void CollectObject(string objectName)
    {
        if (!collectedObjects.ContainsKey(objectName))
        {
            collectedObjects[objectName] = 0;
        }
        collectedObjects[objectName]++;

        // Check if all objects of this type have been collected
        if (!totalObjects.ContainsKey(objectName))
        {
            totalObjects[objectName] = 0;
        }
        if (collectedObjects[objectName] >= totalObjects[objectName])
        {
            allCollected[objectName] = true;
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
