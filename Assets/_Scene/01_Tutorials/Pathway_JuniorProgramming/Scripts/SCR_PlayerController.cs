using UnityEngine;
using UnityEngine.InputSystem;

public class SCR_PlayerController : MonoBehaviour
{
    //Variable to store the speed of the vehicle
    public float speed = 5.0f;
    //Variable to store the turn speed of the vehicle
    public float turnSpeed;
    //Variable to store the input action for movement
    public InputAction moveAction;
    //Variable to store the input action for turning
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Enable the input action for movement
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the input value for movement
        moveInput = moveAction.ReadValue<Vector2>();

        // Moving the Vehicle Foreward and Backward
        // transform.Translate(0, 0, 1);
        // transform.Translate(Vector3.forward);
        // transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        // Moving the Vehicle Left and Right
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * moveInput.x);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);

    }
}
