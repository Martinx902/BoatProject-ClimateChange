//Martin Pérez Villabrille
//Cat & Potions 
//Last Modification 04/11/2022

using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    #region Inspector Variables

    [Header("Player Transform")]
    [Space(15)]
    [SerializeField]
    private Transform target;

    [Header("Smooth Damp Value")]
    [Space(15)]
    [SerializeField]
    [Range(0f, 1f)] 
    private float smoothTime = 0.25f;

    #endregion

    private Vector3 offset;

    private Vector3 currentVelocity = Vector3.zero;

    private void Awake()
    {
        //Gets the offset distance between player and camera
        offset = transform.position - target.position;
    }

    private void FixedUpdate()
    {
        //Sets the target position to where it needs to be adding the offset to keep the camera always at the same distance
        Vector3 targetPosition = target.position + offset;

        //Updates de position of the camera smoothing the transitions between where it is and where it needs to be
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothTime);
    }
}
