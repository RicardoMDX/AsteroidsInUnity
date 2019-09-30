using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed, maxSpeed = 2f, turnRate=20f;
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
        speed = Input.GetKey("W");

    }
}
