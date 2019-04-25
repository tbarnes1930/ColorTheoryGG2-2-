using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip keySound;

    [Range(0.0f, 1.0f)]
    public float keyVolume;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            audioSource.PlayOneShot(keySound, keyVolume);
            
            PlayerInventory.keyCount++;
            print("I have " + PlayerInventory.keyCount + " key(s)!");
            
            other.gameObject.GetComponent<Renderer>().enabled = false;
            
            other.gameObject.GetComponent<ParticleSystem>().Play();

            other.gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
