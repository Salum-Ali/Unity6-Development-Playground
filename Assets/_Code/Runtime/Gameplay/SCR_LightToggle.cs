using UnityEngine;

public class SCR_LightToggle : MonoBehaviour
{
    public Light myLight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //yes, the following lines of comments are intentionally verbose to provide a detailed explanation of the code's functionality and usage within the Unity environment.
        //and are a result of the AI's attempt to provide a comprehensive understanding of the code's purpose and implementation.
        //because i'm too lazy to write a proper summary...
        // Toggle the light on and off when the "L" key is pressed
        // Check if the "L" key is pressed down
        // If it is, toggle the enabled state of the light
        // This means if the light is currently on, it will be turned off, and if it is off, it will be turned on
        // The "!" operator is used to invert the current state of the light's enabled property
        // This allows for a simple toggle functionality with a single key press
        // The Input.GetKeyDown method is used to detect the key press event, which only triggers once when the key is initially pressed down
        // This is different from Input.GetKey, which would continuously trigger as long as the key is held down
        // The Light component must be assigned in the Unity Inspector for this script to work correctly
        // Make sure to drag and drop the Light component from the scene into the "myLight" field in the Inspector
        // This script can be attached to any GameObject in the scene, and it will control the specified Light component
        // This is a simple and effective way to add interactivity to your scene, allowing players to control lighting with a key press
        // Remember to test the functionality in Play mode to ensure that the light toggles correctly when the "L" key is pressed
        // This script can be expanded or modified to include additional features, such as changing light colors, intensities, or adding sound effects when toggling the light
        // Overall, this script provides a basic yet functional way to control lighting in a Unity scene, enhancing the player's experience and interaction with the environment.
        if (Input.GetKeyDown(KeyCode.L))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
