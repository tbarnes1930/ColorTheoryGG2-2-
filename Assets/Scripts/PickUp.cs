using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip keySound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            audioSource.PlayOneShot(keySound);
            
            PlayerInventory.keyCount++;
            print("I have " + PlayerInventory.keyCount + " key(s)!");
            
            other.gameObject.GetComponent<Renderer>().enabled = false;
            
            other.gameObject.GetComponent<ParticleSystem>().Play();

            other.gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
