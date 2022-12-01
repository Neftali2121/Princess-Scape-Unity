using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Diagnostics;
using UnityEngine;

public class CollitionPrincess : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Bee"))
        {
            UnityEngine.Debug.Log("Game Over!");
            MoveForward.gameOver = true;
        }
    }
}
