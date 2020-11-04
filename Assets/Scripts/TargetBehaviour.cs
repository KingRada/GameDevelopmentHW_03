using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetBehaviour : MonoBehaviour
{
    public NavMeshAgent agent;
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

        new_location.x = Random.Range(15f, 38f); ;
        new_location.z = Random.Range(-5f, -26f);
        new_location.y = Terrain.activeTerrain.SampleHeight(new_location);

        transform.position = new_location;

        agent.SetDestination(transform.position);

    }
}
