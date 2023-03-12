using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        ICollisionable collisionObject = collision.gameObject.GetComponent<ICollisionable>();

        if (collisionObject == null)
            return;

        collisionObject.OnCollision();
    }
}