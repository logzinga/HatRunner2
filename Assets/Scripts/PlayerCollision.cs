using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
        public PlayerMovement playerMovement;

    void OnCollisionEnter (Collision collisionInfo) // This so for when the Player Collides with an Object
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Obstacle Hit!");
            playerMovement.enabled = false;
        }
    }
}
