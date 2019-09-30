using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed=1f, maxSpeed = 2f, turnSpeed=20f;

    private float movementInput, turnInput;
    private Rigidbody2D playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB=GetComponent<Rigidbody2D>();
        speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        movementInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
    }

    private void Move()
    {
        Vector2 movement = transform.forward * movementInput * speed * Time.deltaTime;
        playerRB.AddForce(movement);
    }

    private void Turn()
    {
        float turn = turnInput * turnSpeed * Time.deltaTime;
        
        playerRB.MoveRotation(playerRB.rotation * turn);
    }
}
