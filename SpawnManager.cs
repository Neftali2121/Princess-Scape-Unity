using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
public class SpawnManager : MonoBehaviour
{
   
    
    //Random random = new Random();
    public GameObject obstaclePrefab; //Variable for our first prefab
    public GameObject obstaclePrefab2; //Second variable for our second prefab
    public GameObject obstaclePrefab3;
    public GameObject obstaclePrefab4;
    public GameObject obstaclePrefab5;
    public GameObject obstaclePrefab6;
    public GameObject obstaclePrefab7;
    public GameObject obstaclePrefab8;
    public GameObject obstaclePrefab9;
    public GameObject obstaclePrefab10;
    public GameObject obstaclePrefab11;
    public GameObject obstaclePrefab12;
    public GameObject obstaclePrefab13;

    private List<GameObject> Obstacles = new List<GameObject>(); //List to keep our prefabs and generate them randomly.
    private Vector3 spawnPos = new Vector3(100, 0, 0); //starting position of our walking prefabs
    private Vector3 beeSpawnPos = new Vector3(100, 15, 0); //starting position of our flying prefabs
    private Vector3 dragonSpawnPos = new Vector3(110, 16, -8);


    private float startDelay = 0;
    public static float repeatRate = 2f;
    private ControllPlayer playerControllerScript; //get a function from PlayerControllerScript
    private CollitionPrincess collitionPrincessScript;
    public int RandomNumber;


    public TextMeshProUGUI scoreText;
    public static float scoreAmount;
    public float pointIncreasedPerSecond;
    public static bool DragonAppeared = false;

    // Start is called before the first frame update
    void Start()
    {

        Obstacles.Add(obstaclePrefab);  //bear
        Obstacles.Add(obstaclePrefab2); //bear
        Obstacles.Add(obstaclePrefab3); //bear
        Obstacles.Add(obstaclePrefab4); //bear
        Obstacles.Add(obstaclePrefab5); //dilophosaur
        Obstacles.Add(obstaclePrefab6); //dilophosaur
        Obstacles.Add(obstaclePrefab7); //dilophosaur
        Obstacles.Add(obstaclePrefab8); //dilophosaur
        Obstacles.Add(obstaclePrefab9); //bee
        Obstacles.Add(obstaclePrefab10); //bee
        Obstacles.Add(obstaclePrefab11); //bee
        Obstacles.Add(obstaclePrefab12); //bee
        Obstacles.Add(obstaclePrefab13); //dragon



        playerControllerScript = GameObject.Find("Player").GetComponent<ControllPlayer>();
        //collitionPrincessScript = GameObject.Find("1PrincesaDucking").GetComponent<CollitionPrincess>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);   //loop to spawn prefabs
        scoreAmount = 0f;
        pointIncreasedPerSecond = 2f;
       
    }
    

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle()
    {
       

        //RandomNumber = 12;
        RandomNumber = UnityEngine.Random.Range(0, 13);


        if (MoveForward.gameOver == false)
        {
            if (RandomNumber == 8 || RandomNumber == 9 || RandomNumber == 10 || RandomNumber == 11)
            {
                
                Instantiate(Obstacles[RandomNumber], beeSpawnPos, obstaclePrefab.transform.rotation); //spawn flying prefabs
                
            }
            else if (RandomNumber == 0 || RandomNumber == 1 || RandomNumber == 2 || RandomNumber == 3 || RandomNumber == 4 || RandomNumber == 5 || RandomNumber == 6 || RandomNumber == 7)
            {
               
                Instantiate(Obstacles[RandomNumber], spawnPos, obstaclePrefab.transform.rotation); //spawn prefabs

            }

            else if (RandomNumber == 12)
            {
                
                Instantiate(Obstacles[RandomNumber], dragonSpawnPos, Quaternion.Euler(0, 0, 0));
               
            }
        }
    }
}
