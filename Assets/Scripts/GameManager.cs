using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Object brick;
    private DeadZone deadZone;
    private Object currentBrick;
    private Text text;
    public int countBrick = 0;
    private void Awake()
    {
        deadZone = GameObject.Find("DeadZone").GetComponent<DeadZone>();
        text = GameObject.Find("Text").GetComponent<Text>();
    }
    void Start()
    {
        GenerateBrick();
    }
    void FixedUpdate()
    {
        if (deadZone.ballGone == true)
        {
            text.text = "GAME OVER";
        }
        else
        {
            text.text = "Bricks Left: " + countBrick.ToString();
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
