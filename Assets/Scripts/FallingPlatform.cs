using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    bool isFalling = false;
    public float downSpeed = 1;

    public float TimeToFall = 5.0f;

    void OnCollisonEnter(Collision collider)
    {
        if (collider.gameObject.name == "player")
        {
            GetComponent<Rigidbody>().useGravity = true;
            //Destroy(gameObject, TimeToFall);
        }
        if (transform.position.y <= -2.84f)
        {
            Destroy(gameObject);    
        }
    }
}