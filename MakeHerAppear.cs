using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;
public class MakeHerAppear : MonoBehaviour
{
    public GameObject Player2;
    public Vector3 SpawnPos = new Vector3(-44, 3, -3);
    public GameObject Player1;
    public static bool Ducking;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Player2.SetActive(false);
        Player1.SetActive(true);
        Ducking = false;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Player2.SetActive(true);

            Player1.SetActive(false);
            Ducking = true;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Player2.SetActive(false);
            Player1.SetActive(true);
            Ducking = false;
        }
    }
}