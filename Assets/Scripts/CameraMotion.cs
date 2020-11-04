using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour
{

    private float _speed;
    private float _angularSpeed = 1f;
    private float _rotationAngle;
    private CharacterController _characterController;

    // Start is called before the first frame update
    void Start()
    {
        _speed = 1f;
        _rotationAngle = 0f;
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get mouse X-coordinate
        float mouse_x = Input.GetAxis("Mouse X");

        // Translate is one of transformations that uses Vector3
        //transform.Translate(transform.forward * Time.deltaTime * _speed);

        if (Input.GetKey(KeyCode.W))
            _speed += 0.001f;
        else if (Input.GetKey(KeyCode.S))
            _speed -= 0.01f;

        // Sets sight direction by means of tra
        _rotationAngle += mouse_x * _angularSpeed * Time.deltaTime;
        transform.Rotate(0, _rotationAngle, 0);

        // Translate is one of transformations that uses Vector3
        // transform.Translate(Vector3.forward * Time.deltaTime * _speed);

        // We shall use CharacterController to move and to stop if camera collides with another object
        Vector3 direction = transform.TransformDirection(Vector3.forward * Time.deltaTime * _speed);
        _characterController.Move(direction);
    }
}
