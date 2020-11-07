using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target03_Behaviour : MonoBehaviour
{
    public NavMeshAgent agent;
    float[,] locations = { { 30.14f, 24.401f }, { 15.62f, 20.77f }, { 16.96f, 27.68f } };
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
