﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target02_Behaviour : MonoBehaviour
{
    public NavMeshAgent agent;
    float[,] locations = { { 31.6f, 15.49f }, { 36.6f, 39.4f }, { 20.08f, 35.66f } };
    int i;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Vector3 new_location = new Vector3();

        i = Random.Range(0, 3);

        new_location.x = locations[i, 0];
        new_location.z = locations[i, 1];
        new_location.y = 1;

        transform.position = new_location;

        agent.SetDestination(transform.position);

    }
}
