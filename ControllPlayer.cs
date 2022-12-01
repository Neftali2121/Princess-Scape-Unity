using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllPlayer : MonoBehaviour
{
    private Rigidbody playerRb; //to access the rigid body of the player.


    public float jumpForce;  //to be able to modify the jump force in unity.
    public float gravityModifier; //to be able to modify the gravity value in unity
    public bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); //Be able to access the rigid body component.
        Physics.gravity *= gravityModifier; // change the gravity force
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isOnGround)
        {
            Debug.Log("Jump");
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            //playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); //Add a force. Using inpulse mode will add the force really quick.
            //isOnGround = false; //To stop player to double jump.

        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Bee"))
        {
            Debug.Log("Game Over!");
            MoveForward.gameOver = true;
        }

    }
}
