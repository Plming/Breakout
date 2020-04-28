﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Object brick;
    public Object ball;
    private Object currentBrick;
    public Text countText;
    public int countBrick = 0;
    void Start()
    {
        GenerateBrick();
    }
    void FixedUpdate()
    {
        if (ball.ballGone == false)
        {
            countText.text = "GAME OVER";
        }
        else
        {
            countText.text = "Bricks Left: " + countBrick.ToString();
        }
    }

    void GenerateBrick()
    {
        int row, col;
        for (row = 0; row < 7; row++)
        {
            for (col = -5; col < 6; col++)
            {
                currentBrick = Instantiate(brick, new Vector3(1.4f * col, 0.6f * row, 0), new Quaternion(0, 0, 0, 0));
                countBrick++;
            }
        }
    }
}
