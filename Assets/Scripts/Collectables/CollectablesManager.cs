using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectablesManager : MonoBehaviour
{
    //private List<Collectable> collectables = new List<Collectable>();

    public UnityEvent onGameEnded;

    public int numberOfCollectables { get; private set; }

    private void Awake()
    {
        Collectable[] collectables = FindObjectsOfType<Collectable>();

        numberOfCollectables = collectables.Length;

        Debug.Log("Collectables detected: " + numberOfCollectables);
    }

    public void OneMinus()
    {
        numberOfCollectables--;

        if (numberOfCollectables <= 0)
        {
            onGameEnded.Invoke();
            Debug.Log("Game Ended");
        }
        else
        {
            Debug.Log("Collectables left: " + numberOfCollectables);
        }
    }
}