using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    new Rigidbody2D rigidbody;
    public float ballSpeed = 7f;
    private float randomizer = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        //rigidbody.AddForce(new Vector2(10,0));
        rigidbody.velocity = Vector2.down * ballSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.velocity = rigidbody.velocity.normalized * ballSpeed;
        //Debug.Log(rigidbody.velocity);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        randomizer = Random.Range(-1.0f, 1.0f);
        rigidbody.velocity = new Vector2(
            rigidbody.velocity.x + randomizer,
            rigidbody.velocity.y + randomizer);
    }
}
