using UnityEngine;

public class SCR_PlayerFollow : MonoBehaviour
{
    //Variable to store the player gameobject
    //AKA the vehicle that we want to follow
    //AKA the GameObject we want to follow in the inspector
    public GameObject player;
    //Variable to store the offset of the camera from the player
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    //LateUpdate is called after all Update functions have been called
    //This is useful to order script execution. For example a follow camera should always be implemented in LateUpdate because it tracks objects that might have moved inside Update.
    //all-in-all, this end up with the camera following the player SMOOTHLY after the player has moved
    void LateUpdate()
    {
        //offset the camera position to be above and behind the player
        // transform.position = player.transform.position + new Vector3(0, 5, -7);
        transform.position = player.transform.position + offset;
    }
}
