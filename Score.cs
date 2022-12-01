using UnityEngine.UI;
using UnityEngine;
using System;
using TMPro;
using Unity.VisualScripting;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static float scoreAmount;
    public float pointIncreasedPerSecond;
   

    void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSecond = 1f;
       InvokeThePoints();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void AddPoints()
    {
        scoreText.text = "Score = " + (int)scoreAmount;
        scoreAmount += pointIncreasedPerSecond;
    }

    void InvokeThePoints()
    {
        if (MoveForward.gameOver == false)
        {
            InvokeRepeating("AddPoints", 0f, SpawnManager.repeatRate);
        }
    }
}
