 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 1500f;

    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Script Loaded!");
    }

    // FixedUpdate is here due to Unity being picky with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Base Movement, Important 
            // Left and Right Movements, important to movement
        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

          if ( Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
