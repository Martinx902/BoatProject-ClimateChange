using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellFractureModel : MonoBehaviour
{
    private List<Rigidbody> rigidbodies = new List<Rigidbody>();

    [SerializeField]
    private float explosionForce = 250f;

    [SerializeField]
    private float explosionRange = 15f;

    [SerializeField]
    private float lifeTimeExpand = 5f;

    private void Awake()
    {
        for (int i = 0; i <= transform.childCount - 1; i++)
        {
            rigidbodies.Add(transform.GetChild(i).GetComponent<Rigidbody>());
        }
    }

    private void OnEnable()
    {
        foreach (Rigidbody item in rigidbodies)
        {
            item.AddExplosionForce(explosionForce, item.gameObject.transform.position, explosionRange);
            Destroy(gameObject, lifeTimeExpand);
        }
    }
}