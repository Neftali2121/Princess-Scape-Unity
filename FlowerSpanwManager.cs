using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Permissions;
using UnityEngine;

public class FlowerSpanwManager : MonoBehaviour
{
    public GameObject BlueFlower;
    public GameObject WhiteFlower;
    public GameObject RedFlower;
    private Vector3 BlueSpawn = new Vector3(100, 2, -11);
    private Vector3 RedSpawn = new Vector3(100, 2, 6);
    private Vector3 WhiteSpawn = new Vector3(100, 2, -11);
    private List<GameObject> Flowers = new List<GameObject>();
    private float delay = 0;
    private float repeatRate = 3;
    public int RandomNumber; 

    // Start is called before the first frame update
    void Start()
    {
        Flowers.Add(BlueFlower);
        Flowers.Add(WhiteFlower);
        Flowers.Add(RedFlower);
        InvokeRepeating("SpawnFlowers", delay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnFlowers()
    {
        RandomNumber = UnityEngine.Random.Range(0, 3);

        if (MoveForward.gameOver == false )
        {
           if (RandomNumber == 0)
            {
                Instantiate(Flowers[RandomNumber], BlueSpawn, BlueFlower.transform.rotation);
            }

           if (RandomNumber == 1)
            {
                Instantiate(Flowers[RandomNumber], RedSpawn, RedFlower.transform.rotation);
            }
           if (RandomNumber == 2)
            {
                Instantiate(Flowers[RandomNumber], WhiteSpawn, WhiteFlower.transform.rotation);
            }
        }
    }
}
