using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenaltyController : MonoBehaviour
{
    [SerializeField]
    [Range(0.1f, 0.5f)]
    private float movementPenalty = 0.15f;

    private float startMovementPenalty = 1f;

    public float actualPenalty { get; private set; }

    [SerializeField]
    private List<GameObject> boatStates = new List<GameObject>();

    [SerializeField]
    private int lives = 4;

    public GameEvent onGameEnded;

    private void Start()
    {
        actualPenalty = startMovementPenalty;
    }

    public void UpdatePenalty()
    {
        //Rebajarle una vida al jugador
        lives--;

        if (lives == 0)
        {
            //Se acab� el juego
            onGameEnded.Raise();
            Debug.Log("Game ended");
        }

        //Aumentar la movement penalty
        actualPenalty -= movementPenalty;

        Debug.Log("Penalty Updated, actual penalty: " + actualPenalty);

        //A�adirle alg�n feedback al jugador de que el barco cada vez est� m�s jodido
        //ponerle alg�n humillo m�s o particulas de que est� ya bastante chuflas el barco
    }
}