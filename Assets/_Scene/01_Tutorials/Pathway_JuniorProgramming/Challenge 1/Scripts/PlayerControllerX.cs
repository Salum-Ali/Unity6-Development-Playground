using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    // public InputAction verticalAction;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        // verticalAction.Enable();
    }

    // Update is called once per frame
    //FixedUpdate is called every fixed framerate frame, if the MonoBehaviour is enabled.
    // void FixedUpdate()
    void Update()
    {
        // get the user's vertical input
        // verticalInput = Input.GetAxis("Vertical");
        verticalInput = Input.GetAxis("Vertical");
        // verticalInput = verticalAction.ReadValue<Vector2>();

        // move the plane forward at a constant rate
        // transform.Translate(Vector3.back * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        // transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
