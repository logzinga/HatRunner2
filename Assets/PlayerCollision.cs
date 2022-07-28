using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter (Collision collisionInfo) // This so for when the Player Collides with an Object, FIXME
    {
        Debug.Log("Object Hit!" + collisionInfo); 
    }
}
