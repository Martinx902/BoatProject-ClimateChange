using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour, ICollisionable
{
    [SerializeField]
    private float energyDebuff = 5f;

    public CustomEvent onCollision;

    public void OnCollision()
    {
        onCollision?.Invoke(energyDebuff);

        //Destroy(gameObject, 0.5f);
    }
}