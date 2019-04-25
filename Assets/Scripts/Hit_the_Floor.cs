using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_the_Floor : MonoBehaviour
{
    public AudioSource FloorSource;
    public AudioClip SoundOfContact;

    [Range(0.0f, 1.0f)]
    public float FallVolume;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionStay(Collision orange)
    {
        if (orange.gameObject.tag == "Floor")
        {
            FloorSource.PlayOneShot(SoundOfContact, FallVolume);        
            //Debug.Log("The orange has hit the " + orange.gameObject.name);

        }
    }

}
