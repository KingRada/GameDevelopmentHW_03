using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetBehaviour : MonoBehaviour
{
    public NavMeshAgent agent;
    float[,] locations = { { 15.83f, 20.97f }, { 37.599f, 19.3f }, { 23.709f, 40.792f }, { 32.079f, 33.243f }, { 11.86f, 39.23f } };
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

        i = Random.Range(0, 5);

        // new_location.x = Random.Range(15.5f, 20f);
        // new_location.z = Random.Range(15.5f, 25f);
        // new_location.y = Terrain.activeTerrain.SampleHeight(new_location);
        new_location.x = locations[i, 0];
        new_location.z = locations[i, 1];
        new_location.y = 1;




        transform.position = new_location;

        agent.SetDestination(transform.position);

    }
}
