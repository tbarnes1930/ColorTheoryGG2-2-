using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    public float Bounce; // Determines jump height

    void OnCollisionEnter(Collision other)
    {
        other.rigidbody.AddForce(new Vector3(-other.relativeVelocity.x, other.relativeVelocity.y) * Bounce, ForceMode.Impulse);
        // set x value of new force vector to 0.0f, if you need the jump was straight up
    }
}