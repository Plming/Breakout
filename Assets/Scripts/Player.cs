using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    new Rigidbody2D rigidbody;
    public float playerSpeed = 10f;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float inputX;
        inputX=Input.GetAxisRaw("Horizontal");
        Vector2 newVelocity = new Vector2(playerSpeed * inputX, 0);
        rigidbody.velocity = newVelocity;
    }
}
