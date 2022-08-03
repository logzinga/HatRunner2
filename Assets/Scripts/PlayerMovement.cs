 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 4000f; // This is the default Selection for moving forward

    public float sidewaysForce = 100f; // Sideways Force for moving side to side

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Script Loaded!"); // Tells console that the Script loaded CHANGEME
    }

    // FixedUpdate is here due to Unity being picky with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Base Movement, Important 
            // Left and Right Movements, important to movement
        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // Side movement to the Right, Using the D Button
        }

          if ( Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);  // Side movement to the Left, Using the A button
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
