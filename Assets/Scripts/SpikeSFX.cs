using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSFX : MonoBehaviour
{
    public AudioSource SpikeSource;
    
    //public AudioClip RotateSpike;
   
     //[Range(0.0f, 1.0f)]
    //public float SpikeVolume;

    // Start is called before the first frame update
    void Start()
    {
        SpikeSource = GetComponent<AudioSource>();
        SpikeSource.PlayDelayed(0.5f);
    }


}
