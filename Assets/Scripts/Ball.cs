using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    new Rigidbody2D rigidbody;
    GameManager gameManager;
    const float initSpeed = 4f;
    public float speed = initSpeed;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        rigidbody.velocity = Vector2.down * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        ShakeBall();
        if (other.gameObject.tag == "Brick")
        {
            speed = (2 - ((float)gameManager.countBrick / 77f)) * initSpeed;
        }
        rigidbody.velocity = rigidbody.velocity.normalized * speed;
    }

    private void ShakeBall()
    {
        float randomizer = Random.Range(-1f, 1f);
        rigidbody.velocity = new Vector2(
                   rigidbody.velocity.x + randomizer,
                   rigidbody.velocity.y + randomizer);
    }
}
