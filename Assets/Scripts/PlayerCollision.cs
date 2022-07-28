using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
        public PlayerMovement playerMovement; // Linking Player Movement script with Collision Script

    void OnCollisionEnter (Collision collisionInfo) // This so for when the Player Collides with an Object
    {

        if (collisionInfo.collider.tag == "Obstacle") // Does the actions when the Collider has the tag "Obstacle"
        {
            Debug.Log("Obstacle Hit!"); // Sends to Console that the Obstacle has been hit.
            playerMovement.enabled = false; // Disables Player Movement
        }
    }
}
