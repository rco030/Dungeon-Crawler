using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveSpeed;
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

        chController.Move(input * Time.deltaTime);
    }
}
