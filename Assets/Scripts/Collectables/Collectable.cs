using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collectable : MonoBehaviour, ICollisionable
{
    [SerializeField]
    private float points = 5f;

    [SerializeField]
    private ParticleSystem particles;

    [SerializeField]
    private CollectableSequence collectableSequence;

    public CustomEvent onCollect;

    public void OnCollision()
    {
        onCollect?.Invoke(points);

        //StartCoroutine(collectableSequence.OnCollisionSequence(this));

        Destroy(gameObject);
    }
}