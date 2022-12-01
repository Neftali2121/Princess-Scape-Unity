using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed; //animal's or background speed going to the left
    private ControllPlayer playerControllerScript; //Access the other script tp get the game over
    public float leftBound;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<ControllPlayer>();  //Get the componen of game over of the Player(detect if it has crashed with something)
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveForward.gameOver == false)    //Make the objects move only if game over is false.
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed); //make them move left.
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
