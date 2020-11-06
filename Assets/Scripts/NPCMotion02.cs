using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMotion02 : MonoBehaviour
{
    float speed;
    float minDist;
    // Start is called before the first frame update
    void Start()
    {
        speed = 4f;
        minDist = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animation>().Play("walk");
        transform.Translate(transform.forward * speed * Time.deltaTime);
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if(Physics.SphereCast(ray, 0.5f, out hit)) // Check obstacle
        {
            if(hit.distance<minDist) // Change direction
            {
                float angle = Random.Range(-100, 100);
                transform.Rotate(new Vector3(0, angle, 0));
            }
        }
    }
}
