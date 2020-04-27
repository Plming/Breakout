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

    void FixedUpdate()
    {
        Vector2 velocity = new Vector2(playerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0);
        //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
        rigidbody.MovePosition(rigidbody.position + velocity);
    }
}
