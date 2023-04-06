using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // The Object
    public GameObject obj;

    // The Interval
    public float interval = 5;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnNext", interval, interval);
    }

    void SpawnNext()
    {
        Instantiate(obj, transform.position, Quaternion.identity);
    }
}
