using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSandbox : MonoBehaviour
{

    public Rigidbody rb;

void OnCollisionEnter (Collision collisionInfo) 
{
        if (collisionInfo.collider.tag == "Player") // Does the actions when the Collider has the tag "Player"
        {
            Debug.Log("Player Hit!"); // Sends to Console that the Player has been hit.
            rb.AddForce(0, 100000 * Time.deltaTime, 0);
        }

}
}
