using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMoveLeft : MonoBehaviour
{
    public float leftBound; //Boundary so the objects disappear at that location. 
    public float speed; //animal's speed going forward(because we rotated them 90 degrees.)
    public static bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == false) //Make the objects move only if game over is false.
        {

            transform.Translate(Vector3.forward * Time.deltaTime * speed); //make them move forward.

            if (transform.position.x < leftBound && gameObject.CompareTag("Cloud")) //destroy the obstacle.
            {
                Destroy(gameObject);
            }
        }
    }

}
