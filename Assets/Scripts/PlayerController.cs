using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     public float moveSpeed;
    public float startMove;
    public float yRotate;
    public float jumpHeight;
    public Rigidbody rb;
    public bool jumpCheck;

    public AudioSource switchSound;
    public AudioClip switchGrab;


    [Range(0.0f, 1.0f)]
    public float switchVolume;

    public AudioSource jumpSource;
    public AudioClip jumpSound;

    [Range(0.0f, 1.0f)]
    public float jumpVolume;
	
    void Start()
    {
         jumpCheck = true;
         Cursor.visible = false;
        startMove = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Rotate(0, ((Time.deltaTime * yRotate) * -1), 0);
            transform.Translate((Time.deltaTime * (moveSpeed * -1)), 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //transform.Rotate(0, (Time.deltaTime * yRotate), 0);
            transform.Translate((Time.deltaTime * moveSpeed), 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, (Time.deltaTime * (moveSpeed * -1)));

            
        }
		
		 if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetAxis("Mouse X") < 0)
        {
            transform.Rotate(0, ((Time.deltaTime * yRotate) * -1), 0);
        }

        if (Input.GetAxis("Mouse X") > 0)
        {
            transform.Rotate(0, (Time.deltaTime * yRotate), 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, ((Time.deltaTime * yRotate) * -1), 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, (Time.deltaTime * yRotate), 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeed * 2f;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = startMove;
        }
    }
	
	 void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Orange")
        {
            jumpCheck = true;

        }

    }

    void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.tag == "Switch")
         {
             switchSound.PlayOneShot(switchGrab, switchVolume);
         }
     }
	
    
	 private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Orange")
        {
            jumpCheck = false;
            
        }
    }
	
	 void Jump()
    {
        if (jumpCheck == true)
        {
            rb.AddForce(transform.up * jumpHeight);
            jumpSource.PlayOneShot(jumpSound, jumpVolume);
        }
    }

}
