using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    GameManager gameManager;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        setBrickColor();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Ball")
        {
            gameManager.countBrick--;
            Object.Destroy(gameObject);
        }
    }

    private void setBrickColor()
    {
        float r, g, b;
        r = Random.Range(0f, 1f);
        g = Random.Range(0f, 1f);
        b = Random.Range(0f, 1f);
        spriteRenderer.color = new Color(r, g, b);
    }
}
