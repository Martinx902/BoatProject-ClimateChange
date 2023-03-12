using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    private float steerSpeed = 5f;

    [SerializeField]
    private float drag = 10f;

    private Transform boatMotor;
    private float verticalInput;
    private float movementFactor;
    private float horizontalInput;
    private float steerFactor;

    private PenaltyController penaltyController;

    private void Awake()
    {
        penaltyController = GetComponent<PenaltyController>();
    }

    private void FixedUpdate()
    {
        Movement();
        Steer();
    }

    private void Movement()
    {
        verticalInput = Input.GetAxis("Vertical");

        movementFactor = Mathf.Lerp(movementFactor, verticalInput, Time.deltaTime / drag);

        transform.Translate(0, 0, movementFactor * speed * penaltyController.actualPenalty);
    }

    private void Steer()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        steerFactor = Mathf.Lerp(steerFactor, horizontalInput, Time.deltaTime / drag);

        transform.Rotate(0, steerFactor * steerSpeed * penaltyController.actualPenalty, 0);
    }
}