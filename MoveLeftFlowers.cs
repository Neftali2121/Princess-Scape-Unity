using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftFlowers : MonoBehaviour
{
    public float leftBound; //Boundary so the objects disappear at that location. 
    public float speed; //animal's speed going forward(because we rotated them 90 degrees.) 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveForward.gameOver == false )
        {
            if  (MakeHerAppear.Ducking == false)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed); //make them move forward.
            }

            else if (MakeHerAppear.Ducking == true)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * 0); //make them move forward.
            }
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Flower")) //destroy the obstacle.
        {
            Destroy(gameObject);
        }

    }
}
