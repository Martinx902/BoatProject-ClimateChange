using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameEvent onGameStart;

    private void Start()
    {
        onGameStart.Raise();
    }
}