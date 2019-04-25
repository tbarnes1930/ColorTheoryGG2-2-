using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_the_Floor : MonoBehaviour
{
    public AudioSource FloorSource;
    public AudioClip SoundOfContact;

    [Range(0.0f, 1.0f)]
    public float FallVolume;

    public bool floorCheck;

    // Start is called before the first frame update
    void Start()
    {
        floorCheck = false;
    }

    private void OnCollisionEnter(Collision orange)
    {
        if (orange.gameObject.tag == "Floor")
        {
            floorCheck = true;
            
        }

        if (floorCheck == true)
        {
            FloorSource.PlayOneShot(SoundOfContact, FallVolume);
            //Debug.Log("The orange has hit the " + orange.gameObject.name);

        }
    }

   /* private void OnCollisionEnter(Collision restart)
    {
        if (restart.gameObject.tag == "Respawn")
        {
            floorCheck = false;
        }
    }*/

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Floor")
        {
            floorCheck = false;
        }

    }

}
