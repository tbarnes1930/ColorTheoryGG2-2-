using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSFX : MonoBehaviour
{
    public AudioSource SpikeSource;
    
    void Start()
    {
        InvokeRepeating("RedRubyNoise", 1.0f, 2.8f);
        //SpikeSource = GetComponent<AudioSource>();
        //SpikeSource.PlayDelayed(2.1f);
    }

    void RedRudyNoise()
    {
        SpikeSource.Play();
    }
}
