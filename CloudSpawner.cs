using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject BigCloud;
    public GameObject MiniCloud;
    private Vector3 BigCloudSpawn = new Vector3(100, 40, 10);
    private Vector3 MiniCloudSpawn = new Vector3(100, 40, 10);
    private List<GameObject> Clouds = new List<GameObject>();
    private float delay = 2;
    private float repeatRate = 5;
    public int RandomNumber;

    // Start is called before the first frame update
    void Start()
    {
        Clouds.Add(BigCloud);
        Clouds.Add(MiniCloud);
        InvokeRepeating("SpawnClouds", delay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnClouds()
    {
        RandomNumber = UnityEngine.Random.Range(0, 2);

        if (MoveForward.gameOver == false)
        {
            if (RandomNumber == 0)
            {
                Instantiate(Clouds[RandomNumber], BigCloudSpawn, BigCloud.transform.rotation);
            }

            if (RandomNumber == 1)
            {
                Instantiate(Clouds[RandomNumber], MiniCloudSpawn, MiniCloud.transform.rotation);
            }
        }
    }
}
