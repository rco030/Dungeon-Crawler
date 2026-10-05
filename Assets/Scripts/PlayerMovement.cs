using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    private CharacterController chController;

    void Start()
    {
        chController = GetComponent<CharacterController>();
    }

    void Update()
    {
        Move();        
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 input = new Vector3(horizontal, 0, vertical);

        input = Vector3.ClampMagnitude(input, 1.0f);

        Vector3 targetVelocity = input * moveSpeed;

        chController.Move(targetVelocity * Time.deltaTime);
    }
}
