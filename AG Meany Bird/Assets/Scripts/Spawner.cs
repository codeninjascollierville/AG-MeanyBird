using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

[Header("Spikes Object for controlling the game")]
public GameObject spikes;
//Height position of the spikes
[Header("Default Height")]
public float height;
    // Start is called before the first frame update
    void Start()
    {
        //Start function repeating every 4 seconds
        InvokeRepeating("InstantiateObjects", 1f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        //Position for the gameobjects
        transform.position = new Vector3(5, Random.Range(-height, height), 0);
    }
    void InstantiateObjects()
    {
        Instantiate(spikes, transform.position, transform.rotation);
    }
}
//Object that we will attach tp the script for spawning object
