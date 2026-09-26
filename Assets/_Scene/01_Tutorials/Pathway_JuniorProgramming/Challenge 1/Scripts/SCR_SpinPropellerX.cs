using UnityEngine;

public class SCR_SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // spin the propeller around the y-axis at a constant rate
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
