using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDragon : MonoBehaviour
{
    public float leftBound; //Boundary so the objects disappear at that location. 
    public float speed = 50; //animal's speed going forward(because we rotated them 90 degrees.)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveForward.gameOver == false) //Make the objects move only if game over is false.
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed); //make them move forward.
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Dragon")) //destroy the obstacle.
        {
            Destroy(gameObject);
           
        }
        if (Score.scoreAmount > 20)
        {
            speed = 65;
        }
        else if (Score.scoreAmount > 50)
        {
            speed = 80;
        }
        else if (Score.scoreAmount > 80)
        {
            speed = 100;
        }
        else if (Score.scoreAmount > 110)
        {
            speed = 125;
        }
        else if (Score.scoreAmount > 130)
        {
            speed = 140;
        }
        else if (Score.scoreAmount > 160)
        {
            speed = 160;
        }
    }
}
